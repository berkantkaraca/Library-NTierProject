using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Library.Bll.Dtos;
using Library.Bll.Managers.Abstracts;
using Library.Validators.RequestModels.Books;
using Library.Validators.ResponseModels.Books;

namespace Library.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookManager _manager;
        private readonly IMapper _mapper;
        public BookController(IBookManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            List<BookDto> values = await _manager.GetAllAsync();
            List<BookResponseModel> responseModels = _mapper.Map<List<BookResponseModel>>(values);
            return Ok(responseModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            BookDto value = await _manager.GetByIdAsync(id);
            return Ok(_mapper.Map<BookResponseModel>(value));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookRequestModel model)
        {
            BookDto dto = _mapper.Map<BookDto>(model);
            await _manager.CreateAsync(dto);
            return Ok("Created");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBookRequestModel model)
        {
            BookDto dto = _mapper.Map<BookDto>(model);
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
