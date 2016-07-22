using Windows.UI.Xaml;

namespace MarvelDemo.Common
{
    public class DeviceFamilyTrigger : StateTriggerBase
    {
        public string DeviceFamily
        {
            get { return (string)GetValue(DeviceFamilyProperty); }
            set { SetValue(DeviceFamilyProperty, value); }
        }
        
        public static readonly DependencyProperty DeviceFamilyProperty =
            DependencyProperty.Register("DeviceFamily", typeof(string), typeof(DeviceFamilyTrigger),
                new PropertyMetadata(string.Empty, DeviceFamilyChanged));

        private static void DeviceFamilyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var @this = (DeviceFamilyTrigger)dependencyObject;
            var queriedFamily = (string)dependencyPropertyChangedEventArgs.NewValue;
            var currentFamily = Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily;
            @this.SetActive(queriedFamily == currentFamily);
        }
    }
}
