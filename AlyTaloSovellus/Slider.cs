
namespace AlyTaloSovellus

{
    class Slider
    {
        /// <summary>
        /// True when the user is dragging the slider with the mouse
        /// </summary>
        bool sliderThumbDragging = false;

        private void slider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            sliderThumbDragging = true;
        }

        private void slider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            sliderThumbDragging = false;
        }
    }
}
