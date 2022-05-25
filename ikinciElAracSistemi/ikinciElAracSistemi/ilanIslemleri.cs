using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciElAracSistemi
{
    public interface ilanIslemleri
    {

        string ilanOlustur();
        string ilanDuzenle();
        string ilanSil();
        string ilanGoruntule();
        string ilanAra();

    }
}
