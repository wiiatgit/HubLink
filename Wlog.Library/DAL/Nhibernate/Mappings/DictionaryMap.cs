﻿//******************************************************************************
// <copyright file="license.md" company="Wlog project  (https://github.com/arduosoft/wlog)">
// Copyright (c) 2016 Wlog project  (https://github.com/arduosoft/wlog)
// Wlog project is released under LGPL terms, see license.md file.
// </copyright>
// <author>Daniele Fontani, Emanuele Bucaelli</author>
// <autogenerated>true</autogenerated>
//******************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode.Conformist;
using Wlog.BLL.Entities;
using NHibernate.Mapping.ByCode;

namespace Wlog.Library.DAL.Nhibernate.Mappings
{
    public class DictionaryMap : ClassMapping<DictionaryEntity>
    {
        public DictionaryMap()
        {
            Table("wl_dictionary");
            //Schema("dbo");

            Id(x => x.Id, map => { map.Column("DictionaryId"); map.Generator(Generators.Guid); });

            Property(x => x.ApplicationId, m => {  m.UniqueKey("idx_name_app"); });
            
            Property(x => x.Name,m=> {  m.UniqueKey("idx_name_app"); });
        }
    }
}
