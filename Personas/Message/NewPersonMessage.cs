using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace Personas
{
    class NewPersonMessage : ValueChangedMessage<Persona>
    {
        public NewPersonMessage(Persona per) : base(per) { }
    }
}
