using Ninject;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class _Default : Page
    {
        private ICreditCard _creditCard;

        [Inject]
        public void Setup(ICreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            label1.Text = _creditCard.Charge();
        }
    }
}