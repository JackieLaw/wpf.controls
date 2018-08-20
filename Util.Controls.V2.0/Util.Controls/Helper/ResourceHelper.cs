using System.Collections.Generic;
using System.Windows;

namespace Util.Controls
{
    /// <summary>
    /// Application��Դ�������ࡣͨ����ǰApplication��ȡStyle��DataTemplate���ᾲ̬�������
    /// </summary>
    public static class ResourceHelper
    {
        private static Dictionary<string, DataTemplate> _DataTemplates = new Dictionary<string, DataTemplate>();
        private static Dictionary<string, Style> _Styles = new Dictionary<string, Style>();
        /// <summary>
        /// ��ȫ����Դ�в���DataTemplate��Դ���Ỻ�棩
        /// </summary>
        public static DataTemplate FindDataTemplate(string key)
        {
            if (!_DataTemplates.ContainsKey(key))
            {
                var dt = Application.Current.FindResource(key) as DataTemplate;
                _DataTemplates.Add(key, dt);
            }
            return _DataTemplates[key];
        }
        /// <summary>
        /// ��ȫ����Դ�в���Style��Դ���Ỻ�棩
        /// </summary>
        public static Style FindStyle(string key)
        {
            if (!_Styles.ContainsKey(key))
            {
                var dt = Application.Current.FindResource(key) as Style;
                _Styles.Add(key, dt);
            }
            return _Styles[key];
        }
    }
}