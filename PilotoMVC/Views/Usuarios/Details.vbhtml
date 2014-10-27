@ModelType PilotoMVC.PilotoMVC.Testes.Usuario
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Usuario</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Login)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Login)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Senha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Senha)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
