//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Models;
using Apps.Common;
using Unity.Attributes;
using System.Transactions;
using Apps.BLL.Core;
using Apps.Locale;
using LinqToExcel;
using System.IO;
using System.Text;
using Apps.IDAL.Sys;
using Apps.Models.Sys;
using Apps.IBLL.Sys;
namespace Apps.BLL.Sys
{
	public partial class SysSequenceBLL: Virtual_SysSequenceBLL,ISysSequenceBLL
	{
        

	}
	public class Virtual_SysSequenceBLL
	{
        [Dependency]
        public ISysSequenceRepository m_Rep { get; set; }

		public virtual List<SysSequenceModel> GetList(ref GridPager pager, string queryStr)
        {

            IQueryable<SysSequence> queryData = null;
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = m_Rep.GetList(
								
								a=>a.SN.Contains(queryStr)
								|| a.TabName.Contains(queryStr)
								
								|| a.FirstRule.Contains(queryStr)
								
								
								|| a.SecondRule.Contains(queryStr)
								
								
								|| a.ThirdRule.Contains(queryStr)
								
								
								|| a.FourRule.Contains(queryStr)
								
								|| a.JoinChar.Contains(queryStr)
								|| a.Sample.Contains(queryStr)
								|| a.CurrentValue.Contains(queryStr)
								|| a.Remark.Contains(queryStr)
								);
            }
            else
            {
                queryData = m_Rep.GetList();
            }
            pager.totalRows = queryData.Count();
            //排序
            queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
            return CreateModelList(ref queryData);
        }

		public virtual List<SysSequenceModel> GetListByUserId(ref GridPager pager, string userId,string queryStr)
		{
			return new List<SysSequenceModel>();
		}
		
		public virtual List<SysSequenceModel> GetListByParentId(ref GridPager pager, string queryStr,object parentId)
        {
			return new List<SysSequenceModel>();
		}

        public virtual List<SysSequenceModel> CreateModelList(ref IQueryable<SysSequence> queryData)
        {

            List<SysSequenceModel> modelList = (from r in queryData
                                              select new SysSequenceModel
                                              {
													Id = r.Id,
													SN = r.SN,
													TabName = r.TabName,
													FirstType = r.FirstType,
													FirstRule = r.FirstRule,
													FirstLength = r.FirstLength,
													SecondType = r.SecondType,
													SecondRule = r.SecondRule,
													SecondLength = r.SecondLength,
													ThirdType = r.ThirdType,
													ThirdRule = r.ThirdRule,
													ThirdLength = r.ThirdLength,
													FourType = r.FourType,
													FourRule = r.FourRule,
													FourLength = r.FourLength,
													JoinChar = r.JoinChar,
													Sample = r.Sample,
													CurrentValue = r.CurrentValue,
													Remark = r.Remark,
          
                                              }).ToList();

            return modelList;
        }

        public virtual bool Create(ref ValidationErrors errors, SysSequenceModel model)
        {
            try
            {
                SysSequence entity = m_Rep.GetById(model.Id);
                if (entity != null)
                {
                    errors.Add(Resource.PrimaryRepeat);
                    return false;
                }
                entity = new SysSequence();
               				entity.Id = model.Id;
				entity.SN = model.SN;
				entity.TabName = model.TabName;
				entity.FirstType = model.FirstType;
				entity.FirstRule = model.FirstRule;
				entity.FirstLength = model.FirstLength;
				entity.SecondType = model.SecondType;
				entity.SecondRule = model.SecondRule;
				entity.SecondLength = model.SecondLength;
				entity.ThirdType = model.ThirdType;
				entity.ThirdRule = model.ThirdRule;
				entity.ThirdLength = model.ThirdLength;
				entity.FourType = model.FourType;
				entity.FourRule = model.FourRule;
				entity.FourLength = model.FourLength;
				entity.JoinChar = model.JoinChar;
				entity.Sample = model.Sample;
				entity.CurrentValue = model.CurrentValue;
				entity.Remark = model.Remark;
  

                if (m_Rep.Create(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.InsertFail);
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }



         public virtual bool Delete(ref ValidationErrors errors, object id)
        {
            try
            {
                if (m_Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

        public virtual bool Delete(ref ValidationErrors errors, object[] deleteCollection)
        {
            try
            {
                if (deleteCollection != null)
                {
                    using (TransactionScope transactionScope = new TransactionScope())
                    {
                        if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
                        {
                            transactionScope.Complete();
                            return true;
                        }
                        else
                        {
                            Transaction.Current.Rollback();
                            return false;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

		
       

        public virtual bool Edit(ref ValidationErrors errors, SysSequenceModel model)
        {
            try
            {
                SysSequence entity = m_Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add(Resource.Disable);
                    return false;
                }
                              				entity.Id = model.Id;
				entity.SN = model.SN;
				entity.TabName = model.TabName;
				entity.FirstType = model.FirstType;
				entity.FirstRule = model.FirstRule;
				entity.FirstLength = model.FirstLength;
				entity.SecondType = model.SecondType;
				entity.SecondRule = model.SecondRule;
				entity.SecondLength = model.SecondLength;
				entity.ThirdType = model.ThirdType;
				entity.ThirdRule = model.ThirdRule;
				entity.ThirdLength = model.ThirdLength;
				entity.FourType = model.FourType;
				entity.FourRule = model.FourRule;
				entity.FourLength = model.FourLength;
				entity.JoinChar = model.JoinChar;
				entity.Sample = model.Sample;
				entity.CurrentValue = model.CurrentValue;
				entity.Remark = model.Remark;
 


                if (m_Rep.Edit(entity))
                {
                    return true;
                }
                else
                {
                    errors.Add(Resource.NoDataChange);
                    return false;
                }

            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                ExceptionHander.WriteException(ex);
                return false;
            }
        }

      

        public virtual SysSequenceModel GetById(object id)
        {
            if (IsExists(id))
            {
                SysSequence entity = m_Rep.GetById(id);
                SysSequenceModel model = new SysSequenceModel();
                              				model.Id = entity.Id;
				model.SN = entity.SN;
				model.TabName = entity.TabName;
				model.FirstType = entity.FirstType;
				model.FirstRule = entity.FirstRule;
				model.FirstLength = entity.FirstLength;
				model.SecondType = entity.SecondType;
				model.SecondRule = entity.SecondRule;
				model.SecondLength = entity.SecondLength;
				model.ThirdType = entity.ThirdType;
				model.ThirdRule = entity.ThirdRule;
				model.ThirdLength = entity.ThirdLength;
				model.FourType = entity.FourType;
				model.FourRule = entity.FourRule;
				model.FourLength = entity.FourLength;
				model.JoinChar = entity.JoinChar;
				model.Sample = entity.Sample;
				model.CurrentValue = entity.CurrentValue;
				model.Remark = entity.Remark;
 
                return model;
            }
            else
            {
                return null;
            }
        }


		 /// <summary>
        /// 校验Excel数据,这个方法一般用于重写校验逻辑
        /// </summary>
        public virtual bool CheckImportData(string fileName, List<SysSequenceModel> list,ref ValidationErrors errors )
        {
          
            var targetFile = new FileInfo(fileName);

            if (!targetFile.Exists)
            {

                errors.Add("导入的数据文件不存在");
                return false;
            }

            var excelFile = new ExcelQueryFactory(fileName);

            //对应列头
			 				 excelFile.AddMapping<SysSequenceModel>(x => x.SN, "SN");
				 excelFile.AddMapping<SysSequenceModel>(x => x.TabName, "TabName");
				 excelFile.AddMapping<SysSequenceModel>(x => x.FirstType, "FirstType");
				 excelFile.AddMapping<SysSequenceModel>(x => x.FirstRule, "FirstRule");
				 excelFile.AddMapping<SysSequenceModel>(x => x.FirstLength, "FirstLength");
				 excelFile.AddMapping<SysSequenceModel>(x => x.SecondType, "SecondType");
				 excelFile.AddMapping<SysSequenceModel>(x => x.SecondRule, "SecondRule");
				 excelFile.AddMapping<SysSequenceModel>(x => x.SecondLength, "SecondLength");
				 excelFile.AddMapping<SysSequenceModel>(x => x.ThirdType, "ThirdType");
				 excelFile.AddMapping<SysSequenceModel>(x => x.ThirdRule, "ThirdRule");
				 excelFile.AddMapping<SysSequenceModel>(x => x.ThirdLength, "ThirdLength");
				 excelFile.AddMapping<SysSequenceModel>(x => x.FourType, "FourType");
				 excelFile.AddMapping<SysSequenceModel>(x => x.FourRule, "FourRule");
				 excelFile.AddMapping<SysSequenceModel>(x => x.FourLength, "FourLength");
				 excelFile.AddMapping<SysSequenceModel>(x => x.JoinChar, "JoinChar");
				 excelFile.AddMapping<SysSequenceModel>(x => x.Sample, "Sample");
				 excelFile.AddMapping<SysSequenceModel>(x => x.CurrentValue, "CurrentValue");
				 excelFile.AddMapping<SysSequenceModel>(x => x.Remark, "Remark");
 
            //SheetName
            var excelContent = excelFile.Worksheet<SysSequenceModel>(0);
            int rowIndex = 1;
            //检查数据正确性
            foreach (var row in excelContent)
            {
                var errorMessage = new StringBuilder();
                var entity = new SysSequenceModel();
						 				  entity.Id = row.Id;
				  entity.SN = row.SN;
				  entity.TabName = row.TabName;
				  entity.FirstType = row.FirstType;
				  entity.FirstRule = row.FirstRule;
				  entity.FirstLength = row.FirstLength;
				  entity.SecondType = row.SecondType;
				  entity.SecondRule = row.SecondRule;
				  entity.SecondLength = row.SecondLength;
				  entity.ThirdType = row.ThirdType;
				  entity.ThirdRule = row.ThirdRule;
				  entity.ThirdLength = row.ThirdLength;
				  entity.FourType = row.FourType;
				  entity.FourRule = row.FourRule;
				  entity.FourLength = row.FourLength;
				  entity.JoinChar = row.JoinChar;
				  entity.Sample = row.Sample;
				  entity.CurrentValue = row.CurrentValue;
				  entity.Remark = row.Remark;
 
                //=============================================================================
                if (errorMessage.Length > 0)
                {
                    errors.Add(string.Format(
                        "第 {0} 列发现错误：{1}{2}",
                        rowIndex,
                        errorMessage,
                        "<br/>"));
                }
                list.Add(entity);
                rowIndex += 1;
            }
            if (errors.Count > 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        public virtual void SaveImportData(IEnumerable<SysSequenceModel> list)
        {
            try
            {
                using (DBContainer db = new DBContainer())
                {
                    foreach (var model in list)
                    {
                        SysSequence entity = new SysSequence();
                       						entity.Id = 0;
						entity.SN = model.SN;
						entity.TabName = model.TabName;
						entity.FirstType = model.FirstType;
						entity.FirstRule = model.FirstRule;
						entity.FirstLength = model.FirstLength;
						entity.SecondType = model.SecondType;
						entity.SecondRule = model.SecondRule;
						entity.SecondLength = model.SecondLength;
						entity.ThirdType = model.ThirdType;
						entity.ThirdRule = model.ThirdRule;
						entity.ThirdLength = model.ThirdLength;
						entity.FourType = model.FourType;
						entity.FourRule = model.FourRule;
						entity.FourLength = model.FourLength;
						entity.JoinChar = model.JoinChar;
						entity.Sample = model.Sample;
						entity.CurrentValue = model.CurrentValue;
						entity.Remark = model.Remark;
 
                        db.SysSequence.Add(entity);
                    }
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
		public virtual bool Check(ref ValidationErrors errors, object id,int flag)
        {
			return true;
		}

        public virtual bool IsExists(object id)
        {
            return m_Rep.IsExist(id);
        }
		
		public void Dispose()
        { 
            
        }

	}
}
