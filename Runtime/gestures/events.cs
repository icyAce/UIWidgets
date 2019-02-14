using System;
using Unity.UIWidgets.ui;

namespace Unity.UIWidgets.gestures {
    public abstract class PointerEvent {
        public PointerEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null,
            Offset delta = null,
            bool down = false,
            bool synthesized = false
        ) {
            this.timeStamp = timeStamp;
            this.pointer = pointer;
            this.kind = kind;
            this.device = device;
            this.position = position ?? Offset.zero;
            this.delta = delta ?? Offset.zero;
            this.down = down;
            this.synthesized = synthesized;
        }

        public readonly TimeSpan timeStamp;

        public readonly int pointer;

        public PointerDeviceKind kind;

        public int device;

        public readonly Offset position;

        public readonly Offset delta;

        public readonly bool down;

        public readonly bool synthesized;
    }

    public class PointerAddedEvent : PointerEvent {
        public PointerAddedEvent(
            TimeSpan timeStamp,
            PointerDeviceKind kind = PointerDeviceKind.touch,
            int device = 0,
            Offset position = null
        ) : base(
            timeStamp: timeStamp,
            kind: kind,
            device: device,
            position: position
        ) {
        }
    }

    public class PointerRemovedEvent : PointerEvent {
        public PointerRemovedEvent(
            TimeSpan timeStamp,
            PointerDeviceKind kind = PointerDeviceKind.touch,
            int device = 0
        ) : base(
            timeStamp: timeStamp,
            kind: kind,
            device: device
        ) {
        }
    }

    public class PointerScrollStartEvent : PointerEvent {
        public PointerScrollStartEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: true) {
        }
    }
    
    public class PointerScrollEndEvent : PointerEvent {
        public PointerScrollEndEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null,
            Offset delta = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: false,
                delta : delta) {
        }
    }
    
    public class PointerScrollingEvent : PointerEvent {
        public PointerScrollingEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null,
            Offset delta = null,
            bool start = false)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: start,
                delta: delta) {
        }
    }

    public class PointerHoverEvent : PointerEvent {
        public PointerHoverEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: false) {
        }
    }

    public class PointerEnterEvent : PointerEvent {
        public PointerEnterEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: false) {
        }
    }

    public class PointerLeaveEvent : PointerEvent {
        public PointerLeaveEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: false) {
        }
    }

    public class PointerDownEvent : PointerEvent {
        public PointerDownEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: true) {
        }
    }

    public class PointerMoveEvent : PointerEvent {
        public PointerMoveEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null,
            Offset delta = null,
            bool synthesized = false)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                delta: delta,
                down: true,
                synthesized: synthesized) {
        }
    }

    public class PointerUpEvent : PointerEvent {
        public PointerUpEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: false) {
        }
    }

    public class PointerCancelEvent : PointerEvent {
        public PointerCancelEvent(
            TimeSpan timeStamp,
            int pointer = 0,
            PointerDeviceKind kind = PointerDeviceKind.mouse,
            int device = 0,
            Offset position = null)
            : base(
                timeStamp,
                pointer: pointer,
                kind: kind,
                device: device,
                position: position,
                down: false) {
        }
    }
}