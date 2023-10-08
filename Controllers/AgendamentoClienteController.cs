using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class AgendamentoClienteController : Controller
{
    private static List<AgendamentoCliente> agendamentos = new List<AgendamentoCliente>();

    // Ação para exibir a lista de agendamentos
    public IActionResult Index()
    {
        return View(agendamentos);
    }

    // Ação para exibir o formulário de criação de agendamento
    public IActionResult NovoAgendamento()
    {
        return View();
    }

    // Ação para lidar com o POST do formulário de criação
    [HttpPost]
    public IActionResult NovoAgendamento(AgendamentoCliente agendamento)
    {
        agendamento.DataCriacao = DateTime.Now;
        agendamentos.Add(agendamento);

        return RedirectToAction("Index");
    }
}
