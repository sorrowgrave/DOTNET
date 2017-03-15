using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Collections;
namespace DrivingPXL
{
    //Klasse waar de email word doorgestuurd.
    //Author: Kenny Vanrusselt
    //Date: 28/04/2014 19:15
    class SendEmail
    {
        public SendEmail(string password, string receipent, string name, string surname, string recovery)
        {

            var fromAddress = new MailAddress("rijbewijs.pxl@gmail.com", "Driving PXL");
            var toAddress = new MailAddress(receipent, name);
            const string fromPassword = "d5d4X9e;";
            const string subject = "Password Recovery";
            string body = "Dear " + name + " " + surname + ", Your password is: " + password;


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public SendEmail(string validationCode, string receipent, string name, string surname)
        {
            try
            {
                var fromAddress = new MailAddress("rijbewijs.pxl@gmail.com", "Driving PXL");
                var toAddress = new MailAddress(receipent, name);
                const string fromPassword = "d5d4X9e;";
                const string subject = "Email Confirmation";
                string body = "Dear " + name + " " + surname + ", Thank you for your registration. Your validation code is: " + validationCode;


                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (SmtpException)
            {
                throw new NoNetworkException("Email could not be sent, please check your network connection.");
            }

        }

        public SendEmail()
        {
            // TODO: Complete member initialization
        }

        public void EmailSend(string bijlage, string receipent, string name, string surname)
        {
            try
            {
                var fromAddress = new MailAddress("rijbewijs.pxl@gmail.com", "Driving PXL");
                var toAddress = new MailAddress(receipent, name);
                const string fromPassword = "d5d4X9e;";
                const string subject = "Exam results";
                string body = "Dear " + name + " " + surname + ", You have recently made an exam. You can find your results in the attachment! ";
                //Attachment attachment = new System.Net.Mail.Attachment(bijlage);
                
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    
                    Subject = subject,
                    Body = body
                })
                {
                    message.Attachments.Add(new Attachment(bijlage));
                    smtp.Send(message);
                }
            }
            catch (SmtpException)
            {
                throw new NoNetworkException("Email could not be sent, please check your network connection.");
            }

        }

    }
}

