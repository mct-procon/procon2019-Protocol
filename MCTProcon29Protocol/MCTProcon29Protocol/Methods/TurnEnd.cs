﻿using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCTProcon29Protocol.Methods
{
    [MessagePackObject]
    public class TurnEnd
    {
        [Key(0)]
        public byte Turn { get; set; }
    }
}
