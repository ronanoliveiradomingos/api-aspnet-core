using System;
using Model.Base;
using Newtonsoft.Json;

namespace Model
{
    public class Partner: BaseModel
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
