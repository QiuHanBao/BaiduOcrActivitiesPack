﻿using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using Newtonsoft.Json.Linq;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.TaiwanExitentrypermitActivityDisplayName))]
    [LocalizedDescription(nameof(Resources.TaiwanExitentrypermitActivityDescription))]
    public class TaiwanExitentrypermitActivity : BaiduOcrActivityBase
    {
        protected override Task<JObject> InvokeBaiduOcrAsync(Baidu.Aip.Ocr.Ocr baiduOcr, byte[] image, AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            return Task.Run(() => baiduOcr.TaiwanExitentrypermit(image));
        }
    }
}