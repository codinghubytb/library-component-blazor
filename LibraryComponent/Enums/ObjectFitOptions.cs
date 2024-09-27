using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryComponent.Enums
{
    public enum ObjectFitOptions
    {
        Fill,       // L'image est étirée pour remplir le conteneur
        Contain,    // L'image est redimensionnée pour s'adapter en conservant ses proportions
        Cover,      // L'image remplit le conteneur, mais peut être recadrée
        None,       // L'image garde sa taille d'origine
        ScaleDown   // L'image est réduite seulement si elle est plus grande que le conteneur
    }
}
