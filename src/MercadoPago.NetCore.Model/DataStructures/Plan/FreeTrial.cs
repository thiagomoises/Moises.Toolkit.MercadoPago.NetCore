using MercadoPago.NetCore.Model.Resources.Enum;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Plan
{
    public class FreeTrial
    {
        #region Properties

        private int frequency;
        private FrequencyType frequencyType;

        #endregion

        #region Accessors
        public int Frequency 
        { 
            get { return  frequency; } 
            set {  frequency = value; } 
        }
        public FrequencyType FrequencyType 
        { 
            get { return  frequencyType; } 
            set {  frequencyType = value; } 
        }
        #endregion

    }
}
