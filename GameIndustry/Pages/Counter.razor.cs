using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameIndustry.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService single { get; set; }
        [Inject] TransientService transient { get; set; }
        private int currentCount = 0;
        private void IncrementCount()
        {
            currentCount++;
            single.Value++;
            transient.Value++;
        }
    }
}
