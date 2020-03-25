using System.Linq;
using FluentValidation;
using Lykke.Service.InfobipPushProvider.Client.Models.Requests;

namespace Lykke.Service.InfobipPushProvider.Validation
{
    public class SendPushNotificationRequestValidator : AbstractValidator<SendPushNotificationRequest>
    {
        public SendPushNotificationRequestValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.MessageId)
                .NotNull()
                .NotEmpty()
                .WithMessage("Message Id cannot be empty")
                .Length(1, 50)
                .WithMessage("Message Id must be between 1 and 50 characters in length");

            RuleFor(x => x.PushRegistrationId)
                .NotNull()
                .NotEmpty()
                .WithMessage("Push Registration Id cannot be empty")
                .Length(1, 100)
                .WithMessage("Push Registration Id must be between 1 and 100 characters in length");

            RuleFor(x => x.Message)
                .NotNull()
                .NotEmpty()
                .WithMessage("Message cannot be empty")
                .Length(1, 10000)
                .WithMessage("Message must be between 1 and 10000 characters in length");

            RuleFor(x => x.CustomPayload)
                .Custom((customPayload, context) =>
                {
                    if(customPayload.Any(x => x.Key.Length > 200) || customPayload.Any(x => x.Value.Length > 1000))
                        context.AddFailure("Custom Payload is not valid");
                });
        }
    }
}
