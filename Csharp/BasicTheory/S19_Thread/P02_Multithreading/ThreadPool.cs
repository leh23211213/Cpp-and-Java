using System;
using System.Text;
using System.Threading;
class Program {
    static CountdownEvent countdownEvent = new CountdownEvent(10);
    static void Main() {
        Console.OutputEncoding = Encoding.Unicode;
        // Gửi các công việc tới ThreadPool
        for (int i = 0; i < 10; i++) {
            ThreadPool.QueueUserWorkItem(ProcessTask, i);
        }
        // Đợi cho tất cả các công việc hoàn thành
        countdownEvent.Wait();
        Console.WriteLine("Tất cả các công việc đã hoàn thành.");
        Console.ReadKey();
    }
    static void ProcessTask(object state) {
        int taskId = (int)state;
        Console.WriteLine("Công việc {0} đang được thực thi bởi luồng {1}.", taskId, Thread.CurrentThread.ManagedThreadId);
        // Giả lập thời gian xử lý công việc
        Thread.Sleep(1000);
        Console.WriteLine("Công việc {0} đã hoàn thành.", taskId);
        countdownEvent.Signal();
    }
}