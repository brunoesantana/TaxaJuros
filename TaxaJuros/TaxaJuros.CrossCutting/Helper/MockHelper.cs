using System;
using System.Collections.Generic;
using TaxaJuros.Domain;

namespace TaxaJuros.CrossCutting.Helper
{
    public static class MockHelper
    {
        private const double UM_POR_CENTO = 1D / 100;

        public static List<Taxa> GetTaxa()
        {
            return new List<Taxa>
            {
                new Taxa{ Id = Guid.NewGuid(), Value = UM_POR_CENTO }
            };
        }
    }
}