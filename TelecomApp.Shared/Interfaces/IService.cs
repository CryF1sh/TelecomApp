namespace TelecomApp.Shared.Interfaces
{
    public interface IService<TEntity, TEdit, TIDType>
    {
        public List<TEntity> GetAll();
        public List<TEntity> GetAllFull();
        public Task<TEntity?> GetByID(TIDType id);
        public Task<TEntity?> GetByIDFull(TIDType id);

        public Task<TEntity?> Update(TIDType id, TEdit editModel);

        public Task<TEntity?> Create(TEdit editModel);

        public Task<bool> Delete(TIDType id);
    }
}
