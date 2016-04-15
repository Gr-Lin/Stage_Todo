using Android.Content;
using Android.Telephony;
using ModelViewTodo.Interfaces;

namespace TodoList.Services
{
    public class ShareService : AbstractAndroidService, IShareService
    {
        public void SendSms(string phoneNum, string msg)
        {
            SmsManager.Default.SendTextMessage(phoneNum, null, msg, null, null);
        }

        public void SendMail(string[] addresses, string subject, string msg)
        {
             var email = new Intent(Intent.ActionSend);
             email.PutExtra(Intent.ExtraEmail, addresses);
             email.PutExtra(Intent.ExtraSubject, subject);
             email.PutExtra(Intent.ExtraText, msg);
             email.SetType("message/rfc822");
             email.AddFlags(ActivityFlags.NewTask);
             CurrentActivity.StartActivity(email);
         }
    }
}