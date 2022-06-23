using System.Data.Entity.Validation;

namespace FullCRUDImplementationWithJquery.Controllers
{
    internal class FormattedDbEntityValidationException
    {
        private DbEntityValidationException ex;

        public FormattedDbEntityValidationException(DbEntityValidationException ex)
        {
            this.ex = ex;
        }
    }
}