﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2012-12-11 22:12:12 by App
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Attributes;
using Apps.Models;
using Apps.Common;
using Apps.BLL.Core;
using Apps.IBLL;
using Apps.IDAL;
using Apps.Models.Sys;
using Apps.Locale;

namespace Apps.BLL.Sys
{
    public partial class SysAreasBLL 
    {

       
        public List<SysAreasModel> GetList(string parentId)
        {
            IQueryable<SysAreas> queryData = null;
            queryData = m_Rep.GetList(a => a.ParentId == parentId).OrderBy(a => a.Sort);
            return CreateModelList(ref queryData);
        }
      

    }
}