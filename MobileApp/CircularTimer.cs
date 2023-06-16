using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace MobileApp
{
    public class CircularTimer : SKCanvasView
    {
        private float _timerValue = 100f; // начальное значение таймера
        private SKPaint _backgroundPaint;
        private SKPaint _borderPaint;
        private SKPaint _progressPaint;
        private SKPaint _textPaint;

        public CircularTimer()
        {
            _backgroundPaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.White
            };

            _borderPaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Blue,
                StrokeWidth = 10,
                IsAntialias = true
            };

            _progressPaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = SKColors.White,
                StrokeWidth = 10,
                IsAntialias = true
            };

            _textPaint = new SKPaint
            {
                Style = SKPaintStyle.Fill,
                Color = SKColors.Black,
                TextSize = 80f
            };

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // обновляем значение таймера каждую секунду
                _timerValue -= 1f;
                InvalidateSurface();
                return true;
            });
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);

            var canvas = e.Surface.Canvas;
            canvas.Clear();

            var info = e.Info;
            var centerX = info.Width / 2f;
            var centerY = info.Height / 2f;
            var radius = Math.Min(centerX, centerY) - _borderPaint.StrokeWidth / 2f;

            // рисуем фоновый круг
            canvas.DrawCircle(centerX, centerY, radius, _backgroundPaint);

            // рисуем контур круга
            var borderPath = new SKPath();
            borderPath.AddCircle(centerX, centerY, radius);
            canvas.DrawPath(borderPath, _borderPaint);

            // рисуем прогресс таймера
            var progressPath = new SKPath();
            progressPath.AddArc(new SKRect(centerX - radius, centerY - radius, centerX + radius, centerY + radius), -90f, _timerValue / 100f * 360f);
            canvas.DrawPath(progressPath, _progressPaint);

            // рисуем значение таймера в центре круга
            var textBounds = new SKRect();
            _textPaint.MeasureText(_timerValue.ToString(), ref textBounds);
            canvas.DrawText(_timerValue.ToString(), centerX - textBounds.MidX, centerY - textBounds.MidY, _textPaint);
        }

        public void Paint(SKPaintSurfaceEventArgs e)
        {
            this.OnPaintSurface(e);
        }
    }
}
