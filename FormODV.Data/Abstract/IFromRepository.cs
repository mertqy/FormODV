using FormODV.Data.Concrete;

namespace FormODV.Data.Abstract;

public interface IFormRepository
{
    IQueryable<Form> Forms { get; }
    void CrateForm(Form entity);
}
