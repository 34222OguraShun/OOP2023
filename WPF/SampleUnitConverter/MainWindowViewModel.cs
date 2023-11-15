using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double //metricValue, imperialValue,
                       weightValue, poundValue;


 /*       public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }
*/
/*        public double ImperialValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }
*/
        public double WeightValue {
            get { return this.weightValue; }
            set {
                this.weightValue = value;
                this.OnPropertyChanged();
            }
        }

        public double PoundValue {
            get { return this.poundValue; }
            set {
                this.poundValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        //public MetricUnit CurrentMetricUnit { get; set; }
        public WeightUnit CurrentWeightUnit { get; set; }
        //下のComboBoxで選択されている値（単位）
        //public ImperialUnit CurrentImperialUnit { get; set; }
        public PoundUnit CurrentPoundUnit { get; set; }


        //▲ボタンで呼ばれるコマンド
        //public ICommand ImperialUnitToMetric { get; private set; }
        public ICommand PoundUnitToWeight { get; private set; }
        //▼ボタンで呼ばれるコマンド
        //public ICommand MetricToImperialUnit { get; private set; }
        public ICommand WeightToPoundUnit { get; private set; }

        //コンストラクタ
        //      public MainWindowViewModel() {
        //          this.CurrentMetricUnit = MetricUnit.Units.First();
        //          this.CurrentImperialUnit = ImperialUnit.Units.First();

        //          this.MetricToImperialUnit = new DelegateCommand(
        //              () => this.ImperialValue = this.CurrentImperialUnit.FromMetricUnit(
        //                  this.CurrentMetricUnit, this.MetricValue));

        //          this.ImperialUnitToMetric = new DelegateCommand(
        //              () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit(
        //                  this.CurrentImperialUnit, this.ImperialValue));
        //      }


        public MainWindowViewModel() {
            this.CurrentWeightUnit = WeightUnit.Units.First();
            this.CurrentPoundUnit = PoundUnit.Units.First();

            this.WeightToPoundUnit = new DelegateCommand(
                () => this.PoundValue = this.CurrentPoundUnit.FromWeightUnit(
                    this.CurrentWeightUnit, this.WeightValue));

            this.PoundUnitToWeight = new DelegateCommand(
                () => this.WeightValue = this.CurrentWeightUnit.FromPoundUnit(
                    this.CurrentPoundUnit, this.PoundValue));
        }
    }
}
