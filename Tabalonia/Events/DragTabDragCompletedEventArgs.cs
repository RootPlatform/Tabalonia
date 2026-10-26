using Tabalonia.Controls;

namespace Tabalonia.Events;


public class DragTabDragCompletedEventArgs(RoutedEvent routedEvent, DragTabItem dragItem, VectorEventArgs dragCompletedEventArgs)
    : DragTabItemEventArgs(routedEvent, dragItem)
{
    public VectorEventArgs DragCompletedEventArgs { get; } = dragCompletedEventArgs;
}