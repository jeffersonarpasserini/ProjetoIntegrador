import React from 'react';
import { useEffect, useState } from "react";
import { Modal, ModalBody, ModalHeader, ModalFooter } from 'reactstrap';
import axios from "axios";
import '../User/index.css';
import "bootstrap/dist/css/bootstrap.min.css";

import { useSession } from '../Session/index'
import { useNavigate } from 'react-router-dom';
import PropTypes from 'prop-types';
import InputMask from 'react-input-mask';

const PasswordStrengthIndicator = ({ data }) => {

    const [passwordStrength, setPasswordStrength] = useState('Fraca');

    const checkPasswordStrength = (password) => {
        let strength = 'Inválida';

        if (password.length >= 7) {
            const hasUpperCase = /[A-Z]/.test(password);
            const hasLowerCase = /[a-z]/.test(password);
            const hasNumber = /\d/.test(password);
            const hasSpecialChar = /[!@#$%^&*]/.test(password);

            if (hasUpperCase && hasLowerCase && hasNumber && hasSpecialChar && password.length >= 15) {
                strength = 'Forte';
            } else if ((hasUpperCase || hasLowerCase) && hasNumber && password.length >= 10) {
                strength = 'Média';
            } else if (password.length >= 6) {
                strength = 'Fraca';
            }
        }

        setPasswordStrength(strength);
    };

    useEffect(() => {
        checkPasswordStrength(data);
    }, [data]);

    return (
        <div>
            Força da Senha: <span>{passwordStrength}</span>
        </div>
    );
};

PasswordStrengthIndicator.propTypes = {
    data: PropTypes.any.isRequired,
};

export default function User() {

    const [verifyStatus, setVerifyStatus] = useState(false);
    const { defaultSession, isTokenValid, getAuthConfig, newToken } = useSession();
    const navigate = useNavigate();

    const VerifySession = async () => {
        if (!verifyStatus) {
            setVerifyStatus(true);
            const status = await isTokenValid();
            //console.error(status);
            if (status === false) {
                //console.error('Entrou');
                navigate('/');
            } else {
                if (await newToken() === false) {
                    defaultSession();
                    navigate('/');
                }
            }
        }
    };

    const baseUrl = "https://localhost:7096/api/Usuario";

    const [data, setData] = useState([]);
    const [dataTypeUser, setDataTypeUser] = useState([]);
    const [modalInsert, setModalInsert] = useState(false);
    const [modalEdit, setModalEdit] = useState(false);
    const [modalDelete, setModalDelete] = useState(false);
    const [updateData, setUpdateData] = useState(true);
    const [personName, setPersonName] = useState("");
    const [personEmail, setPersonEmail] = useState("");
    const [userPassword, setUserPassword] = useState("");
    const [personTelephone, setPersonTelephone] = useState("");
    const [personCpfCnpj, setPersonCpfCnpj] = useState("");
    const [personRgIe, setPersonRgIe] = useState("");
    const [userOffice, setUserOffice] = useState("");
    const [userStatus, setUserStatus] = useState("");
    const [idTypeUser, setIdTypeUser] = useState("");
    const [userId, setUserId] = useState("");

    const [errorPersonName, setErrorPersonName] = useState("");
    const [erroPersonEmail, setErrorPersonEmail] = useState("");
    const [erroUserPassword, setErrorUserPassword] = useState("");
    const [erroPersonTelephone, setErrorPersonTelephone] = useState("");
    const [erroPersonCpfCnpj, setErrorPersonCpfCnpj] = useState("");
    const [erroPersonRgIe, setErrorPersonRgIe] = useState("");
    const [erroUserOffice, setErrorUserOffice] = useState("");

    const clearErrors = () => {
        setErrorPersonName('');
        setErrorPersonEmail('');
        setErrorUserPassword('');
        setErrorPersonTelephone('');
        setErrorPersonCpfCnpj('');
        setErrorPersonRgIe('');
        setErrorUserOffice('');
    };

    const [selectUser] = useState({
        id: "",
        nomePessoa: "",
        emailPessoa: "",
        senhaUsuario: "",
        cargoUsuario: "",
        statusUsuario: "",
        idTipoUsuario: ""
    });

    const SelectUser = (user, option) => {
        setUserId(user.id);
        setPersonName(user.nomePessoa);
        setPersonEmail(user.emailPessoa);
        setUserPassword(user.senhaUsuario);
        setPersonName(user.telefonePessoa);
        setPersonEmail(user.cpfCnpjPessoa);
        setPersonName(user.rgIePessoa);
        setUserOffice(user.cargoUsuario);
        setUserStatus(user.statusUsuario);
        setIdTypeUser(user.idTipoUsuario);

        if (option === "Editar") {
            openCloseModalEdit();
        } else {
            openCloseModalDelete();
        }
    };

    const GetOrderTypeUser = async () => {
        await axios.get("https://localhost:7096/api/TipoUsuario", getAuthConfig())
            .then(response => {
                setDataTypeUser(response.data);
            })
            .catch(error => {
                console.log(error);
            });
    };

    const openCloseModalInsert = () => {
        setModalInsert(!modalInsert);
    };

    const openCloseModalEdit = () => {
        setModalEdit(!modalEdit);
    };

    const openCloseModalDelete = () => {
        setModalDelete(!modalDelete);
    };

    const checkEmailExists = (email) => {
        const emailExists = data.some(usuario => usuario.EmailUsuario.toLowerCase().trim() === email.toLowerCase().trim());
        return emailExists;
    };

    function CpfCnpj(cpfCnpj) {
        cpfCnpj = cpfCnpj.trim();

        if (cpfCnpj.length === 14) {
            if (
                cpfCnpj[3] === '.' &&
                cpfCnpj[7] === '.' &&
                cpfCnpj[11] === '-'
            ) {
                cpfCnpj = cpfCnpj.replace(/\./g, '').replace('-', '');
                if (!/^\d+$/.test(cpfCnpj)) return -3;

                if (verificarCpf(cpfCnpj)) return 1;
                else return -1;
            }
        } else {
            if (
                cpfCnpj[2] === '.' &&
                cpfCnpj[6] === '.' &&
                cpfCnpj[10] === '/' &&
                cpfCnpj[15] === '-'
            ) {
                cpfCnpj = cpfCnpj.replace(/\./g, '').replace(/\//g, '').replace('-', '');
                if (!/^\d+$/.test(cpfCnpj)) return -3;

                if (verificarCnpj(cpfCnpj)) return 2;
                else return -2;
            }
        }
        return 0;
    }

    function verificarCpf(cpf) {
        const multiplicador1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
        const multiplicador2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];
        let tempCpf = cpf.substring(0, 9);
        let soma = 0;

        for (let i = 0; i < 9; i++) {
            soma += parseInt(tempCpf[i]) * multiplicador1[i];
        }
        let resto = soma % 11;
        resto = resto < 2 ? 0 : 11 - resto;
        let digito = resto.toString();
        tempCpf += digito;
        soma = 0;
        for (let i = 0; i < 10; i++) {
            soma += parseInt(tempCpf[i]) * multiplicador2[i];
        }
        resto = soma % 11;
        resto = resto < 2 ? 0 : 11 - resto;
        digito += resto.toString();
        return cpf.endsWith(digito);
    }

    function verificarCnpj(cnpj) {
        const multiplicador1 = [5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];
        const multiplicador2 = [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];
        let soma = 0;
        let resto;
        let digito;
        let tempCnpj = cnpj.substring(0, 12);

        for (let i = 0; i < 12; i++) {
            soma += parseInt(tempCnpj[i]) * multiplicador1[i];
        }
        resto = soma % 11;
        resto = resto < 2 ? 0 : 11 - resto;
        digito = resto.toString();
        tempCnpj += digito;
        soma = 0;
        for (let i = 0; i < 13; i++) {
            soma += parseInt(tempCnpj[i]) * multiplicador2[i];
        }
        resto = soma % 11;
        resto = resto < 2 ? 0 : 11 - resto;
        digito += resto.toString();
        return cnpj.endsWith(digito);
    }

    function RgIe(rgIe) {
        rgIe = rgIe.trim();

        if (rgIe.length === 12) {
            if (
                rgIe[2] === '.' &&
                rgIe[6] === '.' &&
                rgIe[10] === '-'
            ) {
                rgIe = rgIe.replace(/\./g, '').replace('-', '');
                if (!/^\d+$/.test(rgIe)) return -3;

                if (verificarRg(rgIe)) return 1;
                else return -1;
            }
        } else {
            if (
                rgIe[3] === '.' &&
                rgIe[7] === '.' &&
                rgIe[11] === '.'
            ) {
                rgIe = rgIe.replace(/\./g, '');
                if (!/^\d+$/.test(rgIe)) return -3;

                if (verificarIe(rgIe)) return 2;
                else return -2;
            }
        }
        return 0;
    }

    function verificarRg(rg) {
        const multiplicador1 = [2, 3, 4, 5, 6, 7, 8, 9];
        let soma = 0;
        let resto;
        for (let i = 0; i < 8; i++) {
            soma += parseInt(rg[i]) * multiplicador1[i];
        }
        resto = soma % 11;
        resto = resto < 2 ? 0 : 11 - resto;
        return rg.endsWith(resto.toString());
    }

    function verificarIe(ie) {
        let intSoma = 0;
        let intPeso = 1;

        for (let intPos = 0; intPos < 8; intPos++) {
            let intValor = parseInt(ie[intPos]);
            intValor *= intPeso;
            intSoma += intValor;
            intPeso++;

            if (intPeso === 2) {
                intPeso = 3;
            }

            if (intPeso === 9) {
                intPeso = 10;
            }
        }

        let intResto = intSoma % 11;
        let strDigito1 = intResto.toString().substring(intResto.toString().length - 1);
        let strBase2 = ie.substring(0, 8) + strDigito1 + ie.substring(9, 3);

        return strBase2 === ie;
    }

    const verificarDados = () => {
        var status = true;

        if (!personName) {
            setErrorPersonName('O nome é requerido!');
            status = false;
        }

        if (personEmail) {

            const emailExists = checkEmailExists(personEmail);

            if (emailExists) { setErrorPersonEmail('Este e-mail já existe!'); }
            status = false;

        } else {
            setErrorPersonEmail('O e-mail é requerido!');
            status = false;
        }

        if (userPassword) {

            if (userPassword.length <= 6) { setErrorUserPassword('A senha precisa ter no mínimo 6 caracteres!'); }
            status = false;

        } else {
            setErrorUserPassword('A senha é requerida!');
            status = false;
        }

        if (!personTelephone) {
            setErrorPersonTelephone('O telefone é requerido!');
            status = false;
        }

        if (/\d/.test(personCpfCnpj)) {

            const response = CpfCnpj(personCpfCnpj);

            if (response === -1) { setErrorPersonCpfCnpj('CPF inválido!'); }
            else if (response === -2) { setErrorPersonCpfCnpj('CNPJ inválido!'); }
            else if (response === -3) { setErrorPersonCpfCnpj('Documento incorreto!'); }
            status = false;

        } else {
            setErrorPersonCpfCnpj('O CPF ou CNPJ é requerido!');
            status = false;
        }

        if (/\d/.test(personRgIe)) {

            const response = RgIe(personRgIe);

            if (response === -1) { setErrorPersonCpfCnpj('RG inválido!'); }
            else if (response === -2) { setErrorPersonCpfCnpj('IE inválido!'); }
            else if (response === -3) { setErrorPersonCpfCnpj('Documento incorreto!'); }
            status = false;

        } else {
            setErrorPersonRgIe('O RG ouIE é requerido!');
            status = false;
        }

        if (!userOffice) {
            setErrorUserOffice('O cargo é requerido!');
            status = false;
        }

        return status;
    }

    const GetOrderUser = async () => {
        await axios.get(baseUrl, getAuthConfig())
            .then(response => {
                setData(response.data);
            })
            .catch(error => {
                console.log(error);
            });
    };

    const PostOrder = async () => {

        clearErrors();
        var response = verificarDados();

        if (response) {

            delete selectUser.id;
            const postData = {
                nomePessoa: personName,
                emailPessoa: personEmail,
                senhaUsuario: userPassword,
                telefonePessoa: personTelephone,
                cpfCnpjPessoa: personCpfCnpj,
                rgIePessoa: personRgIe,
                cargoUsuario: userOffice,
                statusUsuario: Boolean(userStatus),
                idTipoUsuario: idTypeUser
            };
            await axios.post(baseUrl, postData, getAuthConfig())
                .then(response => {
                    setData(data.concat(response.data));
                    openCloseModalInsert();
                })
                .catch(error => {
                    console.log(error);
                });

        }
    };

    const PutOrder = async () => {

        clearErrors();
        var response = verificarDados();

        if (response) {

            delete selectUser.id;
            await axios.put(baseUrl, {
                id: userId,
                nomePessoa: personName,
                emailPessoa: personEmail,
                senhaUsuario: userPassword,
                telefonePessoa: personTelephone,
                cpfCnpjPessoa: personCpfCnpj,
                rgIePessoa: personRgIe,
                cargoUsuario: userOffice,
                statusUsuario: Boolean(userStatus),
                idTipoUsuario: idTypeUser
            }, getAuthConfig())
                .then(response => {
                    var answer = response.data;
                    setData(data.map(user => user.id === selectUser.id ? answer : user));
                    openCloseModalEdit();
                })
                .catch(error => {
                    console.log(error);
                });

        }
    };

    const DeleteOrder = async () => {
        await axios.delete(baseUrl + "/" + userId, getAuthConfig())
            .then(response => {
                setData(data.filter(user => user.id !== response.data));
                openCloseModalDelete();
            })
            .catch(error => {
                console.log(error);
            });
    };

    useEffect(() => {
        if (updateData) {
            VerifySession();
            GetOrderUser();
            GetOrderTypeUser();
            setUpdateData(false);
        }
    }, [updateData]);

    const handleKeyDown = (e) => {
        const charCode = e.which ? e.which : e.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            e.preventDefault();
        }
    };

    const [maskCpfCnpj, setMaskCpfCnpj] = useState("999.999.999-99");
    const [maskRgIe, setMaskRgIe] = useState("999.999.999.999");

    const implementMaskCpfCnpj = (e) => {
        if (e === "cpf") {
            setMaskCpfCnpj("999.999.999-99");
        } else if (e === "cnpj") {
            setMaskCpfCnpj("99.999.999/9999-99");
        }
    };

    const implementMaskRgIe = (e) => {
        if (e === "rg") {
            setMaskRgIe("99.999.999-9");
        } else if (e === "ie") {
            setMaskRgIe("999.999.999.999");
        }
    };

    function togglePasswordVisibility() {
        const passwordInput = document.getElementById('passwordInput');
        const passwordIcon = document.querySelector('.toggle-password');

        if (passwordInput.type === 'password') {
            passwordInput.type = 'text';
            passwordIcon.classList.remove('fa-eye');
            passwordIcon.classList.add('fa-eye-slash');
        } else {
            passwordInput.type = 'password';
            passwordIcon.classList.remove('fa-eye-slash');
            passwordIcon.classList.add('fa-eye');
        }
    };

    return (
        <div className="user-container">
            <br />
            <h3>Lista de Usuários</h3>
            <header>
                <button className="btn btn-success" onClick={() => openCloseModalInsert()}>Adicionar</button>
            </header>
            <table className="table table-bordered">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>E-mail</th>
                        <th>Tipo Usuário</th>
                        <th>Status</th>
                        <th>Cargo</th>
                        <th>Telefone</th>
                        <th>CPF / CNPJ</th>
                        <th>RG / IE</th>
                        <th>Ações</th>
                    </tr>
                </thead>
                <tbody>
                    {data.map(user => {
                        const tipoUsuario = dataTypeUser.find(typeuser => typeuser.id === user.idTipoUsuario);

                        return (
                            <tr key={user.id}>
                                <td>{user.nomePessoa}</td>
                                <td>{user.emailPessoa}</td>
                                <td>{tipoUsuario ? tipoUsuario.nomeTipoUsuario : 'Tipo de usuário não encontrado!'}</td>
                                <td>{user.statusUsuario ? 'Ativo' : 'Inativo'}</td>
                                <td>{user.cargoUsuario}</td>
                                <td>{user.telefonePessoa}</td>
                                <td>{user.cpfCnpjPessoa}</td>
                                <td>{user.rgIePessoa}</td>
                                <td>
                                    <button className="btn btn-primary" onClick={() => SelectUser(user, "Editar")}>Editar</button>{"  "}
                                    <button className="btn btn-danger" onClick={() => SelectUser(user, "Excluir")}>Remover</button>
                                </td>
                            </tr>
                        );
                    })}
                </tbody>
            </table>
            <Modal isOpen={modalInsert}>
                <ModalHeader>Cadastrar Usuário</ModalHeader>
                <ModalBody>
                    <div className="form-group">
                        <label>Nome: </label>
                        <br />
                        <input type="text" className="form-control" onChange={(e) => setPersonName(e.target.value)} />
                        <br />
                        <label>E-mail:</label>
                        <br />
                        <input type="text" className="form-control" onChange={(e) => setPersonEmail(e.target.value)} />
                        <div className="error-message">{erroPersonEmail}</div>
                        <br />
                        <label>Senha:</label>
                        <br />
                        <div class="password-input">
                            <input type="password" className="form-control" onChange={(e) => setUserPassword(e.target.value)} id="passwordInput" />
                            <i class="toggle-password fas fa-eye" onClick={() => togglePasswordVisibility()} ></i>
                        </div>
                        <PasswordStrengthIndicator data={userPassword} />
                        <br />
                        <label>Cargo: </label>
                        <br />
                        <input type="text" className="form-control" onChange={(e) => setUserOffice(e.target.value)} />
                        <br />
                        <label>Telefone: </label>
                        <br />
                        <InputMask mask="(99) 99 99999-9999" type="text" className="form-control" onKeyDown={handleKeyDown} onChange={(e) => setPersonTelephone(e.target.value)} />
                        <br />
                        <label>CPF / CNPJ: </label>
                        <br />
                        <select className="form-control" onChange={(e) => implementMaskCpfCnpj(e.target.value)}>
                            <option key="cpf" value="cpf">
                                CPF
                            </option>
                            <option key="cnpj" value="cnpj">
                                CNPJ
                            </option>
                        </select>
                        <br />
                        <InputMask mask={maskCpfCnpj} type="text" className="form-control" onKeyDown={handleKeyDown} onChange={(e) => setPersonCpfCnpj(e.target.value)} />
                        <br />
                        <label>RG / IE: </label>
                        <br />
                        <select className="form-control" onChange={(e) => implementMaskRgIe(e.target.value)}>
                            <option key="rg" value="rg">
                                RG
                            </option>
                            <option key="ie" value="ie">
                                IE
                            </option>
                        </select>
                        <br />
                        <InputMask mask={maskRgIe} type="text" className="form-control" onKeyDown={handleKeyDown} onChange={(e) => setPersonCpfCnpj(e.target.value)} />
                        <br />
                        <label>Status:</label>
                        <br />
                        <select className="form-control" onChange={(e) => setUserStatus(e.target.value === "true")}>
                            <option key="true" value="true">
                                Ativo
                            </option>
                            <option key="false" value="false">
                                Inativo
                            </option>
                        </select>
                        <br />
                        <label>Tipo Usuário:</label>
                        <br />
                        <select className="form-control" onChange={(e) => setIdTypeUser(e.target.value)}>
                            {dataTypeUser.map((typeuser) => (
                                <option key={typeuser.id} value={typeuser.id}>
                                    {typeuser.nomeTipoUsuario}
                                </option>
                            ))}
                        </select>
                    </div>
                </ModalBody>
                <ModalFooter>
                    <button className="btn btn-primary" onClick={() => PostOrder()}>Cadastrar</button>{"  "}
                    <button className="btn btn-danger" onClick={() => openCloseModalInsert()}>Cancelar</button>
                </ModalFooter>
            </Modal>
            <Modal isOpen={modalEdit}>
                <ModalHeader>Editar Usuário</ModalHeader>
                <ModalBody>
                    <div className="form-group">
                        <label>ID: </label><br />
                        <input type="text" className="form-control" readOnly value={userId} /> <br />

                        <label>Nome:</label>
                        <input type="text" className="form-control" name="nomePessoa" onChange={(e) => setPersonName(e.target.value)} value={personName} />
                        <br />
                        <label>E-mail:</label>
                        <br />
                        <input type="text" className="form-control" name="emailPessoa" onChange={(e) => setPersonEmail(e.target.value)} value={personEmail} />
                        <div className="error-message">{erroPersonEmail}</div>
                        <br />
                        <label>Senha:</label>
                        <br />
                        <div class="password-input">
                            <input type="password" className="form-control" onChange={(e) => setUserPassword(e.target.value)} value={userPassword} id="passwordInput" />
                            <i class="toggle-password fas fa-eye" onClick={() => togglePasswordVisibility()} ></i>
                        </div>
                        <PasswordStrengthIndicator data={userPassword} />
                        <br />
                        <label>Cargo:</label>
                        <input type="text" className="form-control" name="cargoUsuario" onChange={(e) => setUserOffice(e.target.value)} value={userOffice} />
                        <br />
                        <label>Telefone: </label>
                        <br />
                        <InputMask mask="(99) 99 99999-9999" type="text" className="form-control" onKeyDown={handleKeyDown} onChange={(e) => setPersonTelephone(e.target.value)} value={personTelephone} />
                        <br />
                        <label>CPF / CNPJ: </label>
                        <br />
                        <select className="form-control" onChange={(e) => implementMaskCpfCnpj(e.target.value)}>
                            <option key="cpf" value="cpf">
                                CPF
                            </option>
                            <option key="cnpj" value="cnpj">
                                CNPJ
                            </option>
                        </select>
                        <br />
                        <InputMask mask={maskCpfCnpj} type="text" className="form-control" onKeyDown={handleKeyDown} onChange={(e) => setPersonCpfCnpj(e.target.value)} />
                        <br />
                        <label>RG / IE: </label>
                        <br />
                        <select className="form-control" onChange={(e) => implementMaskRgIe(e.target.value)}>
                            <option key="rg" value="rg">
                                RG
                            </option>
                            <option key="ie" value="ie">
                                IE
                            </option>
                        </select>
                        <br />
                        <InputMask mask={maskRgIe} type="text" className="form-control" onKeyDown={handleKeyDown} onChange={(e) => setPersonCpfCnpj(e.target.value)} />
                        <label>Status:</label>
                        <br />
                        <select className="form-control" onChange={(e) => setUserStatus(e.target.value === "true")}>
                            <option value="true" selected={userStatus === true}>Ativo</option>
                            <option value="false" selected={userStatus === false}>Inativo</option>
                        </select>
                        <br />
                        <label>Tipo Usuário:</label>
                        <br />
                        <select className="form-control" onChange={(e) => setIdTypeUser(e.target.value)}>
                            {dataTypeUser.map((typeuser) => (
                                <option key={typeuser.id} value={typeuser.id} selected={typeuser.id === idTypeUser}>
                                    {typeuser.nomeTipoUsuario}
                                </option>
                            ))}
                        </select>
                        <br />
                    </div>
                </ModalBody>
                <ModalFooter>
                    <button className="btn btn-primary" onClick={() => PutOrder()}>Cadastrar</button>{"  "}
                    <button className="btn btn-danger" onClick={() => openCloseModalEdit()}>Cancelar</button>
                </ModalFooter>
            </Modal>
            <Modal isOpen={modalDelete}>
                <ModalBody>
                    Confirma a exclusão deste usuário {selectUser && selectUser.nomePessoa} ?
                </ModalBody>
                <ModalFooter>
                    <button className='btn btn-primary' onClick={() => DeleteOrder()}>Sim</button>
                    <button className='btn btn-danger' onClick={() => openCloseModalDelete()}>Não</button>
                </ModalFooter>
            </Modal>
        </div >
    );
}