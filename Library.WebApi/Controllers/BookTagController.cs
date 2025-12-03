using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Validators.RequestModels.BookTags;
using Library.Validators.ResponseModels.BookTags;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTagController : ControllerBase
    {
        private readonly IBookTagManager _manager;
        private readonly IMapper _mapper;
        public BookTagController(IBookTagManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            List<BookTagDto> values = await _manager.GetAllAsync();
            List<BookTagResponseModel> responseModels = _mapper.Map<List<BookTagResponseModel>>(values);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            BookTagDto value = await _manager.GetByIdAsync(id);
            return Ok(_mapper.Map<BookTagResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookTagRequestModel model)
        {
            BookTagDto dto = _mapper.Map<BookTagDto>(model);
            await _manager.CreateAsync(dto);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBookTagRequestModel model)
        {
            BookTagDto dto = _mapper.Map<BookTagDto>(model);
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
