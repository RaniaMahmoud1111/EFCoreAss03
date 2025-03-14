using Microsoft.EntityFrameworkCore;

namespace EFCoreAss03.DomainModels
{ //Pocp class is a  class that has  properities only plain old clr object 

    [Owned]
    internal class Topic
    {
        public string Name { get; set; }
    }

}
