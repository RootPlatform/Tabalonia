using Tabalonia.Controls;

namespace Tabalonia.Events;


public class DragTabDragStartedEventArgs(RoutedEvent routedEvent, DragTabItem tabItem, VectorEventArgs dragStartedEventArgs)
    : DragTabItemEventArgs(routedEvent, tabItem)
{
    public VectorEventArgs DragStartedEventArgs { get; } = dragStartedEventArgs;
}