using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Base
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

        DateTime? _dateCreate;
        public DateTime? DateCreate
        {
            get { return !_dateCreate.HasValue ? DateTime.Now : _dateCreate; }
            set { _dateCreate = value; }
        }

        public DateTime DateModified { get; set; }

        public bool Active { get; set; }

    }
}
