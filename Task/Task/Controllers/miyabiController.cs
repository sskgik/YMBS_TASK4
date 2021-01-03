﻿//WEBアプリケーションサーバサイドの設計の課題
//課題１ miyabiからコイン枚数を取得するメソッドを設計してください！(GETでもPOSTでもどちらでも可)
//課題２　miyabiに送金の指示を出して送金をするメソッドを完成させてください！(GETでもPOSTでもどちらでも可)
//ヒント:過去に作成したAssetテーブル操作のサンプル操作をうまく追加してください！

//課題３　モバイルクライアントなどクライアント側からjsonリクエストの内容を受け取るコンストラクターを設計してください
//ヒントのURL:https://github.com/sskgik/ChaChaCoinWebApi_20201220/tree/master/ChaChaCoin/Controllers
//課題４ 作成したメソッドに対してドメインのルーティングを行ってください！

//課題5　view/Homeディレクトリのcshtmlファイルとwwwrootに必要なcssファイルを作ってweb上でのUIを設計して自身で作成したControllerが動作することを証明してください！（結合テスト）
// 5.1 WEBサイト用のUIを設計してください！
// 5.2 フロントエンドのアプリケーションは課題３のモバイルクライアントのソースコードを使用可能！(Jqueryなら)  
//結合テストに関するヒントは :https://github.com/sskgik/ChaChaCoinWebApi_20201220/tree/master/ChaChaCoin のViewとwwwrootのChaChaMobileDemo関連がヒントになります！

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class miyabiController : ControllerBase
    {
        // GET: api/<miyabiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<miyabiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<miyabiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<miyabiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<miyabiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
