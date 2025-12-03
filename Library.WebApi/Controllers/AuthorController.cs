using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Validators.RequestModels.Authors;
using Library.Validators.ResponseModels.Authors;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorManager _manager;
        private readonly IMapper _mapper;
        public AuthorController(IAuthorManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            List<AuthorDto> values = await _manager.GetAllAsync();
            List<AuthorResponseModel> responseModels = _mapper.Map<List<AuthorResponseModel>>(values);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            AuthorDto value = await _manager.GetByIdAsync(id);
            return Ok(_mapper.Map<AuthorResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthorRequestModel model)
        {
            AuthorDto dto = _mapper.Map<AuthorDto>(model);
            await _manager.CreateAsync(dto);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateAuthorRequestModel model)
        {
            AuthorDto dto = _mapper.Map<AuthorDto>(model);
            await _manager.UpdateAsync(dto);
            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            string result = await _manager.SoftDeleteAsync(id);
            return Ok(result);
        }
    }
}
