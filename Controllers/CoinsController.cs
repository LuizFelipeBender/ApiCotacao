using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiCotacao.Repository.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiCotacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinsController : ControllerBase
    {
        private readonly IBaseRepository _repository;
   //     private readonly IMapper _mapper;

        //Retorna a ultima ocorrência das moedas selecionadas.
        //Ex.: https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL
        private const string  LastCoins = "https://economia.awesomeapi.com.br/last/";  

        public CoinsController(IBaseRepository repository) 
        {
            _repository = repository;
        }


        [HttpGet("/HttpGet")]
        public async Task<IActionResult> GetTheCoins([FromQuery] string Coin1, string Coin2,int vezes)
        {
        for (int i = 0; i < vezes; i++)
        {            
     //   Thread.Sleep(30000);
        var httpclient = new HttpClient();
        var response = await httpclient.GetAsync(LastCoins+Coin1+"-"+Coin2);   
        var result =  response.Content.ReadAsStringAsync().Result;
        }
        return await _repository.SaveChangesAsync()
        ? Ok("Dados adicionado com sucesso")
        : BadRequest("Erro ao salvar os dados");
        }
        //https://www.youtube.com/watch?v=w_Rl0BomHWs
    }
}