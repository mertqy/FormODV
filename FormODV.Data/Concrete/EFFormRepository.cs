using FormODV.Data.Concrete;


namespace FormODV.Data.Abstract;

public class EFFormRepository : IFormRepository
{
    private FormDbContext _context;
    public EFFormRepository(FormDbContext context)
    {
        _context = context;
    }
    public IQueryable<Form> Forms => _context.Forms;

    public void CrateForm(Form entity)
    {
        throw new NotImplementedException();
    }
}