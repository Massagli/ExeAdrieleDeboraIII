function Cadastrar() {
    const inputId = document.querySelector(.txt_id)
    const inputNome = document.querySelector(.txt_nome)
    const inputFuncao = document.querySelector(.txt_funcao)

    if (inputId.value = null && inputNome.value == null && inputFuncao.value == null) {
        window.location.href = "Funcionario.Index"
    }
}