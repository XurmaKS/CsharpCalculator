using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculator2._0
{
    public interface IAllMessage
    {
        void MessageBeginningOfWork();

        void MessageError();

        void MessageInput();

        void ResultOperation(double result);
    }
}