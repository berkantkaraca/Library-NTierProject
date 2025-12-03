using AutoMapper;
using Library.Bll.Managers.Abstracts;
using Library.Bll.ErrorHandling;
using Library.Bll.Dtos;
using Library.Entities.Models;
using Library.Dal.Repositories.Abstracts;
using Library.Entities.Enums;

namespace Library.Bll.Managers.Concretes
{
    public abstract class BaseManager<T, U> : IManager<T, U> where T : class, IDto where U : BaseEntity
    {
        private readonly IRepository<U> _repository;
        protected readonly IMapper _mapper;

        protected BaseManager(IRepository<U> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(T entity)
        {
            await ExceptionHandler.ExecuteAsync(async () =>
            {
                // Giriş ve çıkış değerlerinin unit testi için uygun şekilde incelenmesi için bu şekilde yazıldı.
                U domainEntity = _mapper.Map<U>(entity);
                domainEntity.CreatedDate = DateTime.Now;
                domainEntity.Status = DataStatus.Inserted;

                await _repository.CreateAsync(domainEntity);
            });
        }
        //Mutable dto:

        public List<T> GetActives()
        {
            return ExceptionHandler.Execute(() =>
            {
                List<U> values = _repository.Where(x => x.Status != DataStatus.Deleted).ToList();
                return _mapper.Map<List<T>>(values);
            });
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await ExceptionHandler.ExecuteAsync(async () =>
            {
                List<U> values = await _repository.GetAllAsync();
                return _mapper.Map<List<T>>(values);
            });
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await ExceptionHandler.ExecuteAsync(async () =>
            {
                U value = await _repository.GetByIdAsync(id);
                return _mapper.Map<T>(value);
            });
        }

        public List<T> GetPassives()
        {
            return ExceptionHandler.Execute(() =>
            {
                List<U> values = _repository.Where(x => x.Status == DataStatus.Deleted).ToList();
                return _mapper.Map<List<T>>(values);
            });
        }

        public List<T> GetUpdateds()
        {
            return ExceptionHandler.Execute(() =>
            {
                List<U> values = _repository.Where(x => x.Status == DataStatus.Updated).ToList();
                return _mapper.Map<List<T>>(values);
            });
        }

        public async Task<string> HardDeleteAsync(int id)
        {
            return await ExceptionHandler.ExecuteAsync(async () =>
            {
                U originalValue = await _repository.GetByIdAsync(id);

                if (originalValue == null || originalValue.Status != DataStatus.Deleted)
                    //throw new Exception("Sadece pasif ve bulunabilen veriler silinebilir"); //bu Task<string> yerine Task olduğu zaman kullanılabilir
                    return "Sadece pasif ve bulunabilen veriler silinebilir";

                await _repository.DeleteAsync(originalValue);

                return $"{id} id'li veri silinmistir";
            });
        }

        public async Task<string> SoftDeleteAsync(int id)
        {
            return await ExceptionHandler.ExecuteAsync(async () =>
            {
                U originalValue = await _repository.GetByIdAsync(id);

                if (originalValue == null || originalValue.Status == DataStatus.Deleted)
                    return "Veri pasif veya  bulunumadı";

                originalValue.Status = DataStatus.Deleted;
                originalValue.DeletedDate = DateTime.Now;
                await _repository.SaveChangesAsync();

                return $"{id} id'li veri pasife cekiilmistir";
            });
        }

        public async Task UpdateAsync(T entity)
        {
            await ExceptionHandler.ExecuteAsync(async () =>
            {
                //TODO: Hata yönetimi ekle
                U originalValue = await _repository.GetByIdAsync(entity.Id);

                U newValue = _mapper.Map<U>(entity);
                newValue.UpdatedDate = DateTime.Now;
                newValue.Status = DataStatus.Updated;

                await _repository.UpdateAsync(originalValue, newValue);
            });
        }
    }
}
