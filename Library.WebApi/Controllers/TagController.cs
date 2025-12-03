using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Validators.RequestModels.Tags;
using Library.Validators.ResponseModels.Tags;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly ITagManager _manager;
        private readonly IMapper _mapper;
        public TagController(ITagManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            List<TagDto> values = await _manager.GetAllAsync();
            List<TagResponseModel> responseModels = _mapper.Map<List<TagResponseModel>>(values);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            TagDto value = await _manager.GetByIdAsync(id);
            return Ok(_mapper.Map<TagResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTagRequestModel model)
        {
            TagDto dto = _mapper.Map<TagDto>(model);
            await _manager.CreateAsync(dto);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTagRequestModel model)
        {
            TagDto dto = _mapper.Map<TagDto>(model);
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
