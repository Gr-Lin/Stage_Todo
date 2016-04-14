namespace ModelViewTodo.Interfaces
{
    public interface IShareService
    {
        void SendSms(string phoneNum, string msg);
        void SendMail(string[] addresses, string subject, string msg);
    }
}
