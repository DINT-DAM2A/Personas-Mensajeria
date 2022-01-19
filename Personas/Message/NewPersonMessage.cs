using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NewPersonMessage : ValueChangedMessage<Persona>
    {
        public NewPersonMessage(Persona per) : base(per) { }
    }
}
