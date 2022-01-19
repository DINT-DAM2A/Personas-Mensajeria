using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace Personas
{
    class NewNacionalidadMessage : ValueChangedMessage<string>
    {
        public NewNacionalidadMessage(string nacionalidad) : base(nacionalidad) { }
    }
}
