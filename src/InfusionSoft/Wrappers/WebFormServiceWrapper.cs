//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfusionSoft
{
    using Definition;
    
    
    internal partial class WebFormServiceWrapper : ServiceBase<IWebFormServiceDefinition>, IWebFormService
    {
        
        public WebFormServiceWrapper(InfusionSoft.IInfusionSoftConfiguration configuration) : 
                base(configuration)
        {
        }
        
        public virtual object GetMap()
        {
            return Invoke(d => d.GetMap(ApiKey));
        }
    }
}