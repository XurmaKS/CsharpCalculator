namespace Calculator2._0
{
    public interface IAllMessage
    {
        void MessageBeginningOfWork();

        void MessageError();

        void MessageInput();

        void ResultOperation();
    }
}