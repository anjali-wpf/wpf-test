using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace WpfControlToolkit
{
    public class HBarPanel : Panel
    {
        private static void OnValuesChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            HBarPanel v = sender as HBarPanel;
            if (v == null)
                return;
            ItemCollection oldItems = args.OldValue as ItemCollection;
            ItemCollection newItems = args.NewValue as ItemCollection;
            if (oldItems != null)
                ((INotifyCollectionChanged)oldItems).CollectionChanged -= new NotifyCollectionChangedEventHandler(v.HBarPanel_CollectionChanged);

            if (args.Property == HBarPanel.XValuesProperty)
            {
                if (GetXValues(v) != null)
                    GetXValues(v).CollectionChanged += new NotifyCollectionChangedEventHandler(v.HBarPanel_CollectionChanged);
            }
            else if (args.Property == HBarPanel.YValuesProperty)
            {
                if (GetYValues(v) != null)
                    GetYValues(v).CollectionChanged += new NotifyCollectionChangedEventHandler(v.HBarPanel_CollectionChanged);
            }
            v.InvalidateArrange();
            v.InvalidateVisual();
        }

        private void HBarPanel_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            InvalidateArrange();
            InvalidateVisual();
        }
        
        protected override Size MeasureOverride(Size availableSize)
        {
            for (int i = 0; i < InternalChildren.Count; i++)
            {
                InternalChildren[i].Measure(availableSize);
            }
            return base.MeasureOverride(availableSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            int count = Math.Min(XValues.Count, YValues.Count);
            count = Math.Min(count, InternalChildren.Count);
            for (int i = 0; i < count; i++)
            {
                Rect r = new Rect(new Point(GetZeroReferenceLinePosition(this), YValues[i]), new Point(XValues[i], YValues[i+1]));
                InternalChildren[i].Arrange(r);
            }
            return finalSize;
        }

        private ObservableCollection<double> XValues
        {
            get { return (ObservableCollection<double>)GetXValues(this); }
            set { SetXValues(this, value); }
        }

        public static ObservableCollection<double> GetXValues(DependencyObject obj)
        {
            return (ObservableCollection<double>)obj.GetValue(XValuesProperty);
        }

        public static void SetXValues(DependencyObject obj, ObservableCollection<double> value)
        {
            obj.SetValue(XValuesProperty, value);
        }

        // Using a DependencyProperty as the backing store for XValues.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty XValuesProperty =
            DependencyProperty.RegisterAttached("XValues", typeof(ObservableCollection<double>), typeof(HBarPanel), new UIPropertyMetadata(null, new PropertyChangedCallback(OnValuesChanged)));


        private ObservableCollection<double> YValues
        {
            get { return (ObservableCollection<double>)GetYValues(this); }
            set { SetYValues(this, value); }
        }

        public static ObservableCollection<double> GetYValues(DependencyObject obj)
        {
            return (ObservableCollection<double>)obj.GetValue(YValuesProperty);
        }

        public static void SetYValues(DependencyObject obj, ObservableCollection<double> value)
        {
            obj.SetValue(YValuesProperty, value);
        }

        // Using a DependencyProperty as the backing store for YValues.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty YValuesProperty =
            DependencyProperty.RegisterAttached("YValues", typeof(ObservableCollection<double>), typeof(HBarPanel), new UIPropertyMetadata(null, new PropertyChangedCallback(OnValuesChanged)));


        public Pen ReferenceLinePen
        {
            get { return (Pen)GetValue(ReferenceLinePenProperty); }
            set { SetValue(ReferenceLinePenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ReferenceLinePen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ReferenceLinePenProperty =
            DependencyProperty.Register("ReferenceLinePen", typeof(Pen), typeof(HBarPanel), new UIPropertyMetadata(new Pen(Brushes.Black, 1.0)));



        public static double GetZeroReferenceLinePosition(DependencyObject obj)
        {
            return (double)obj.GetValue(ZeroReferenceLinePositionProperty);
        }

        public static void SetZeroReferenceLinePosition(DependencyObject obj, double value)
        {
            obj.SetValue(ZeroReferenceLinePositionProperty, value);
        }

        // Using a DependencyProperty as the backing store for ZeroReferenceLinePosition.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ZeroReferenceLinePositionProperty =
            DependencyProperty.RegisterAttached("ZeroReferenceLinePosition", typeof(double), typeof(HBarPanel), new UIPropertyMetadata(null));
    }
}