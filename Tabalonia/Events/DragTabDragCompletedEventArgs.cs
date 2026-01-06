using Tabalonia.Controls;

namespace Tabalonia.Events;


public class DragTabDragCompletedEventArgs(RoutedEvent routedEvent, DragTabItem dragItem, VectorEventArgs _)
    : DragTabItemEventArgs(routedEvent, dragItem);