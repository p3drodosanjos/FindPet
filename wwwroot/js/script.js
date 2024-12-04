// Fun��o para consultar o CEP e preencher os campos automaticamente
document.getElementById('CEP').addEventListener('input', function() {
    var cep = document.getElementById('CEP').value.replace(/\D/g, ''); // Remove caracteres n�o num�ricos
    
    if (cep.length === 8) { // Verifica se o CEP tem 8 d�gitos
        var url = `https://viacep.com.br/ws/${cep}/json/`;
        
        // Faz a requisi��o para o ViaCEP
        fetch(url)
            .then(response => response.json())
            .then(data => {
                if (!data.erro) {
                    // Preenche os campos com os dados do endere�o
                    document.getElementById('Rua').value = data.logradouro;
                    document.getElementById('Bairro').value = data.bairro;
                    document.getElementById('Cidade').value = data.localidade;
                    document.getElementById('Estado').value = data.uf;
                    document.getElementById('Pais').value = "Brasil"; // O ViaCEP s� retorna informa��es brasileiras, ent�o podemos definir o pa�s diretamente
                } else {
                    alert('CEP n�o encontrado.');
                }
            })
            .catch(error => {
                console.error('Erro ao consultar o CEP:', error);
                alert('Erro ao buscar informa��es do CEP.');
            });
    }
});
