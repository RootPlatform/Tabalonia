using Tabalonia.Controls;

namespace Tabalonia.Events;


public class DragTabDragStartedEventArgs(RoutedEvent routedEvent, DragTabItem tabItem, VectorEventArgs _)
    : DragTabItemEventArgs(routedEvent, tabItem);