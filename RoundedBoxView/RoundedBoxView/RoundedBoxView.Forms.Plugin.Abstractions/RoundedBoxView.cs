using Xamarin.Forms;

namespace RoundedBoxView.Forms.Plugin.Abstractions
{
    public class RoundedBoxView : BoxView
    {
        public static readonly BindableProperty BorderCornerRadiusProperty =
            BindableProperty.Create("BorderCornerRadius", typeof (double), typeof (RoundedBoxView), default(double));

        public double BorderCornerRadius {
            get { return (double) GetValue(BorderCornerRadiusProperty); }
            set { SetValue(BorderCornerRadiusProperty, value); }
        }

		/// <summary>
		/// Thickness property of border
		/// </summary>
		public static readonly BindableProperty BorderThicknessProperty =
			BindableProperty.Create<RoundedBoxView, int>(
				p => p.BorderThickness, 0);

		/// <summary>
		/// Border thickness of circle image
		/// </summary>
		public int BorderThickness
		{
			get { return (int)GetValue(BorderThicknessProperty); }
			set { SetValue(BorderThicknessProperty, value); }
		}

		/// <summary>
		/// Color property of border
		/// </summary>
		public static readonly BindableProperty BorderColorProperty =
			BindableProperty.Create<RoundedBoxView, Color>(
				p => p.BorderColor, Color.White);

		/// <summary>
		/// Border Color of circle image
		/// </summary>
		public Color BorderColor
		{
			get { return (Color)GetValue(BorderColorProperty); }
			set { SetValue(BorderColorProperty, value); }
		}
    }
}
