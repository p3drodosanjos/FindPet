// Função para consultar o CEP e preencher os campos automaticamente
document.getElementById('CEP').addEventListener('input', function() {
    var cep = document.getElementById('CEP').value.replace(/\D/g, ''); // Remove caracteres não numéricos
    
    if (cep.length === 8) { // Verifica se o CEP tem 8 dígitos
        var url = `https://viacep.com.br/ws/${cep}/json/`;
        
        // Faz a requisição para o ViaCEP
        fetch(url)
            .then(response => response.json())
            .then(data => {
                if (!data.erro) {
                    // Preenche os campos com os dados do endereço
                    document.getElementById('Rua').value = data.logradouro;
                    document.getElementById('Bairro').value = data.bairro;
                    document.getElementById('Cidade').value = data.localidade;
                    document.getElementById('Estado').value = data.uf;
                    document.getElementById('Pais').value = "Brasil"; // O ViaCEP só retorna informações brasileiras, então podemos definir o país diretamente
                } else {
                    alert('CEP não encontrado.');
                }
            })
            .catch(error => {
                console.error('Erro ao consultar o CEP:', error);
                alert('Erro ao buscar informações do CEP.');
            });
    }
});
