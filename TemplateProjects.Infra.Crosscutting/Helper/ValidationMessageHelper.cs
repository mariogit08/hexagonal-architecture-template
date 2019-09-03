using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using $safeprojectname$.Extensions;
using $safeprojectname$.Responses;

namespace  $safeprojectname$.Helper
{
    public static class ValidationMessageHelper
    {
        public static ValidationMessage Create(string messageWithId)
        {
            string[] idAndMessage = messageWithId.Split('-');

            int id;

            if (int.TryParse(idAndMessage.ElementAtOrDefault(0), out id))
            {
                return new ValidationMessage(idAndMessage.ElementAtOrDefault(1).Trim(), id);
            }
            else
                throw new ApplicationException();
        }

        public static ValidationMessage Create(int messageId)
        {
            ResourceManager ValidationMessages = new ResourceManager(typeof(ValidationMessages));

            ResourceSet resourceSet = ValidationMessages.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            var validationMessage = from message in resourceSet.Cast<DictionaryEntry>()
                                    where Create(message.Value as string).MessageId == messageId
                                    select Create(message.Value as string);

            if (!validationMessage.IsNullOrEmpty())
                return validationMessage.FirstOrDefault();
            else
                throw new ApplicationException();
        }

        public static ValidationMessage SearchAndCreate(string messagem)
        {
            ResourceManager ValidationMessages = new ResourceManager(typeof(ValidationMessages));

            ResourceSet resourceSet = ValidationMessages.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            var validationMessage = from message in resourceSet.Cast<DictionaryEntry>()
                                    where Create(message.Value as string).Message == messagem
                                    select Create(message.Value as string);

            if (!validationMessage.IsNullOrEmpty())
                return validationMessage.FirstOrDefault();
            else
                throw new ApplicationException();
        }
    }
}


