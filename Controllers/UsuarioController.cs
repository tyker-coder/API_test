using Microsoft.AspNetCore.Mvc;
using SistemasDeTarefas.Models;
using SistemasDeTarefas.Repositorios.Interfaces;
using System.Text;

namespace SistemaTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuariocontroller : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuariorepositorio;


        public Usuariocontroller(IUsuarioRepositorio usuariorepositorio)
        {
            _usuariorepositorio = usuariorepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> Buscartodosusuarios()
        {
            List<UsuarioModel> usuarios = await _usuariorepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> Buscarporid(int id)
        {
            UsuarioModel usuario = await _usuariorepositorio.BuscarPorId(id);
            return Ok(usuario);

        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuariomodel)
        {
            UsuarioModel usuario = await _usuariorepositorio.Adicionar(usuariomodel);

            return Ok(usuario);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuariomodel, int id)
        {
            usuariomodel.Id = id;
            UsuarioModel usuario = await _usuariorepositorio.Atualizar(usuariomodel, id);
            return Ok(usuario);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Apagar(int id)
        {

            bool apagado = await _usuariorepositorio.Apagar(id);
            return Ok(apagado);

        }
    }

}

