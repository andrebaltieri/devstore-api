using DevStore.Domain;
using DevStore.Infra.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevStore.Api.Controllers
{
    public class ProdutoController : ApiController
    {
        private DevStoreDataContext db = new DevStoreDataContext();
        // GET api/produto
        public HttpResponseMessage Get()
        {
            var result = db.Products.Include("Category").ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
