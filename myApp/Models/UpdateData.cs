using Microsoft.EntityFrameworkCore;

namespace hsintongERP2022.Models
{
    public partial class Model_hsintong
    {
        #region UpdateAsync
        public async Task<string> DoSaveAddChangesAsync(string actionName, Controller controler, string rmk = "")
        {
            return await DoSaveAddChangesAsync(actionName, controler.User.Identity.Name, controler.Request.UserHostAddress, rmk);
        }
        public async Task<Dictionary<string, string>> _SaveAddChangesAsync(string actionName, Controller controler, string rmk = "")
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                if (await DoSaveChangesAsync(eventType.Add, actionName, controler.User.Identity.Name, controler.Request.UserHostAddress, rmk) > 0)
                    result.Add("Ok", "新增儲存完成");
                else
                    result.Add("Ng", "新增失敗");
            }
            catch (DbUpdateException de)
            {
                result.Add("Ng", de.InnerException.InnerException.Message);
                await EventLog.LogEventAsync(new Model_hsintong(), eventType.Add_fail, actionName, controler.User.Identity.Name, result["Ng"], controler.Request.UserHostAddress);
            }
            catch (DbEntityValidationException ex)
            {
                await EventLog.LogEventAsync(new Model_hsintong(), eventType.Add_fail, actionName, controler.User.Identity.Name, ex.Message, controler.Request.UserHostAddress);
                ex.EntityValidationErrors.ForEach(e => e.ValidationErrors.ForEach(err => result.Add(err.PropertyName, err.ErrorMessage)));
                if (ex.InnerException != null)
                    result.Add("Ng", ex.InnerException.Message);
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("未更新"))
                    result.Add("None", ee.Message);
                else
                    result.Add("Ng", ee.Message);
            }
            return result;
        }
        public async Task<string> DoSaveAddChangesAsync(string actionName, string userName, string url, string rmk = "")
        {
            try
            {
                return (await DoSaveChangesAsync(eventType.Add, actionName, userName, url, rmk) > 0) ? "新增儲存完成" : "新增失敗";
            }
            catch (Exception ex)
            {
                var err = ex.ToString();
                await EventLog.LogEventAsync(new Model_hsintong(), eventType.Add_fail, actionName, userName, ex.Message, url);
                return "新增失敗";
            }
        }
        public async Task<Dictionary<string, string>> _SaveUpdateChangesAsync(string actionName, Controller controler, object ids)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                if (await DoSaveChangesAsync(eventType.Add, actionName, controler.User.Identity.Name, controler.Request.UserHostAddress, ids.ToString()) > 0)
                    result.Add("Ok", "修正儲存完成");
                else
                    result.Add("Ng", "修正儲存失敗");
            }
            catch (DbEntityValidationException ex)
            {
                await EventLog.LogEventAsync(new Model_hsintong(), eventType.Add_fail, actionName, controler.User.Identity.Name, ex.Message, controler.Request.UserHostAddress);
                ex.EntityValidationErrors.ForEach(e => e.ValidationErrors.ForEach(err => result.Add(err.PropertyName, err.ErrorMessage)));
                result.Add("Ng", ex.Message);
            }
            catch (DbUpdateException de)
            {
                if (de.Message.Contains("未更新"))
                    result.Add("None", de.Message);
                else
                    result.Add("Ng", de.Message);
            }
            catch (Exception ee)
            {
                if (ee.Message.Contains("未更新"))
                    result.Add("None", ee.Message);
                else
                    result.Add("Ng", ee.Message);
            }
            return result;
        }
        public async Task<string> DoSaveUpdateChangesAsync(string actionName, Controller controller, object ids)
        {
            return await DoSaveUpdateChangesAsync(actionName, controller.User.Identity.Name, controller.Request.UserHostAddress, ids);
        }
        public async Task<string> DoSaveUpdateChangesAsync(string actionName, string usernAME, string url, object ids)
        {
            try
            {
                await DoSaveChangesAsync(eventType.Modify, actionName, usernAME, url, ids.ToString());
                return "修正儲存完成";
            }
            catch (DbUpdateException de)
            {
                return de.Message;
            }
            catch (DbEntityValidationException ex)
            {
                await EventLog.LogEventAsync(new Model_hsintong(), eventType.Modify_fail, actionName, usernAME, "", url);
                return ex.Message;
                // throw ex;
            }
            catch (Exception ee)
            {
                return ee.Message;
            }
            return "存檔失敗";
        }
        public async Task<Dictionary<string, string>> _SaveDeleteChangesAsync(string actionName, Controller controler, object ids)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            try
            {
                if (await DoSaveChangesAsync(eventType.Add, actionName, controler.User.Identity.Name, controler.Request.UserHostAddress, ids.ToString()) > 0)
                    result.Add("Ok", "刪除完成");
                else
                    result.Add("Ng", "刪除失敗");
            }
            catch (DbEntityValidationException ex)
            {
                await EventLog.LogEventAsync(new Model_hsintong(), eventType.Add_fail, actionName, controler.User.Identity.Name, ex.Message, controler.Request.UserHostAddress);
                ex.EntityValidationErrors.ForEach(e => e.ValidationErrors.ForEach(err => result.Add(err.PropertyName, err.ErrorMessage)));
                if (ex.Message.Contains("未更新"))
                    result.Add("None", ex.Message);
                else
                    result.Add("Ng", ex.Message);
            }
            return result;
        }
        public async Task<string> DoSaveDeleteChangesAsync(string actionName, Controller controller, object ids)
        {
            return await DoSaveDeleteChangesAsync(actionName, controller.User.Identity.Name, controller.Request.UserHostAddress, ids);
        }
        public async Task<string> DoSaveDeleteChangesAsync(string actionName, string usernAME, string url, object ids)
        {
            try
            {
                return (await DoSaveChangesAsync(eventType.Delete, actionName, usernAME, url, ids.ToString()) > 0) ? "刪除完成" : "刪除失敗";
            }
            catch (DbEntityValidationException ex)
            {
                await EventLog.LogEventAsync(new Model_hsintong(), eventType.Delete_fail, actionName, usernAME, "", url);
                return "刪除失敗";
                // throw ex;
            }
        }
        private async Task<int> DoSaveChangesAsync(eventType type, string actionName, string usernAME, string url, string rmk)
        {
            int result = 0;
            result = await this.SaveChangesAsync();
            if (result == 0)
            {
                throw new Exception("未更新");
            }
            eventType resultType = (result > 0) ? type :
                (type == eventType.Add) ? eventType.Add_fail :
                (type == eventType.Delete) ? eventType.Delete_fail : eventType.Modify_fail;
            await EventLog.LogEventAsync(this, resultType, actionName, usernAME, rmk, url);
            return result;
        }
        #endregion UpdateAsync
        #region Update
        public string DoSaveAddChanges(string actionName, Controller controler, string rmk = "")
        {
            return DoSaveAddChanges(actionName, controler.User.Identity.Name, controler.Request.UserHostAddress, rmk);
        }
        public string DoSaveAddChanges(string actionName, string userName, string url, string rmk = "")
        {
            try
            {
                return (DoSaveChanges(eventType.Add, actionName, userName, url, rmk) > 0) ? "新增儲存完成" : "新增失敗";
            }
            catch (Exception ex)
            {
                var err = ex.ToString();
                EventLog.LogEvent(new Model_hsintong(), eventType.Add_fail, actionName, userName, ex.Message, url);
                return "新增失敗";
                //throw ex;
            }
        }
        public string DoSaveUpdateChanges(string actionName, Controller controller, object ids)
        {
            return DoSaveUpdateChanges(actionName, controller.User.Identity.Name, controller.Request.UserHostAddress, ids);
        }
        public string DoSaveUpdateChanges(string actionName, string usernAME, string url, object ids)
        {
            try
            {
                DoSaveChanges(eventType.Modify, actionName, usernAME, url, ids.ToString());
                return "修正儲存完成";
            }
            catch (Exception ex)
            {
                EventLog.LogEvent(new Model_hsintong(), eventType.Modify_fail, actionName, usernAME, "", url);
                return "存檔失敗";
                // throw ex;
            }
        }
        public string DoSaveDeleteChanges(string actionName, Controller controller, object ids)
        {
            return DoSaveDeleteChanges(actionName, controller.User.Identity.Name, controller.Request.UserHostAddress, ids);
        }
        public string DoSaveDeleteChanges(string actionName, string usernAME, string url, object ids)
        {
            try
            {
                return (DoSaveChanges(eventType.Delete, actionName, usernAME, url, ids.ToString()) > 0) ? "刪除完成" : "刪除失敗";
            }
            catch (Exception ex)
            {
                EventLog.LogEvent(new Model_hsintong(), eventType.Delete_fail, actionName, usernAME, "", url);
                return "刪除失敗";
                // throw ex;
            }
        }
        private int DoSaveChanges(eventType type, string actionName, string usernAME, string url, string rmk)
        {
            int result = 0;
            result = this.SaveChanges();
            eventType resultType = (result > 0) ? type :
                (type == eventType.Add) ? eventType.Add_fail :
                (type == eventType.Delete) ? eventType.Delete_fail : eventType.Modify_fail;
            EventLog.LogEvent(this, resultType, actionName, usernAME, rmk, url);
            return result;
        }
        #endregion UpdateAsync

    }
}