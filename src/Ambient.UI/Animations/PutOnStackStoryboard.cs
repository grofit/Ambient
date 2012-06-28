using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Ambient.UI.Animations
{
    public class PutOnStackStoryboard : Storyboard
    {
        private DoubleAnimation RotationAnimation;
        private DoubleAnimation ScalingAnimation;

        public PutOnStackStoryboard()
        {
            CreateAnimations();
            SetTargetProperty(RotationAnimation, new PropertyPath(Plane.Plane.RotationYProperty));
            SetTargetProperty(ScalingAnimation, new PropertyPath(Plane.Plane.ScaleXProperty));
            SetTargetProperty(ScalingAnimation, new PropertyPath(Plane.Plane.ScaleYProperty));
        }

        private void CreateAnimations()
        {
            RotationAnimation = new DoubleAnimation()
                                     {
                                         Duration = TimeSpan.FromSeconds(1),
                                         To = 15.0d
                                     };

            ScalingAnimation = new DoubleAnimation()
                                    {
                                        Duration = TimeSpan.FromSeconds(1),
                                        To = 0.5f
                                    };
        }

    }

    public class TakeOffStackStoryboard : Storyboard
    {
        private DoubleAnimation RotationAnimation;
        private DoubleAnimation ScalingAnimation;

        public TakeOffStackStoryboard()
        {
            CreateAnimations();
            SetTargetProperty(RotationAnimation, new PropertyPath(Plane.Plane.RotationYProperty));
            SetTargetProperty(ScalingAnimation, new PropertyPath(Plane.Plane.ScaleXProperty));
            SetTargetProperty(ScalingAnimation, new PropertyPath(Plane.Plane.ScaleYProperty));
        }

        private void CreateAnimations()
        {
            RotationAnimation = new DoubleAnimation()
            {
                Duration = TimeSpan.FromSeconds(1),
                To = 0.0d
            };

            ScalingAnimation = new DoubleAnimation()
            {
                Duration = TimeSpan.FromSeconds(1),
                To = 1.0f
            };
        }

    }
}
