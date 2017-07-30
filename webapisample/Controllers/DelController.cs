using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using webapisample.Models;

namespace webapisample.Controllers
{
    public class DelController : ApiController
    {
		private List<Moge> getmogelist()
		{
			List<Moge> result = new List<Moge>();

			for (int i = 0; i < 10; i++)
			{
				result.Add(new Moge() { id = i + 1, age = i + 10, name = "AS" + i, school = "KN" + 1 });
			}
			return result;
		}

		public HttpResponseMessage Get()
		{
			var mogeList = getmogelist();

			return Request.CreateResponse(HttpStatusCode.OK, new { studentList = mogeList });
		}
    }
}
