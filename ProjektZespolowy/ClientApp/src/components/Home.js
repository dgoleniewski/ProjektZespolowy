import React, { Component } from 'react';
import { Input, Table, Label } from 'semantic-ui-react';

export class Home extends Component {
  constructor(props) {
    super(props);

    this.state = {
      nip: null,
      entre: {},
      loading: false,
    };
    this.handleChange = this.handleChange.bind(this);
    this.search = this.search.bind(this);
  }

  search() {
    this.setState({ loading: true })
    fetch('https://localhost:44373/api/Entrepreneur/' + parseInt(this.state.nip))
      .then((res) => res.json())
      .then((response) => {
        this.setState({ entre: response })
      }).catch((error) => {
        console.log(error);
      }).then(() => { console.log(this.state.entre) }).
      then(() => {
        this.setState({ loading: false })
      })
  }

  handleChange(e) { this.setState({ nip: e.target.value }) };

  static displayName = Home.name;

  render() {
    return (
      <div>
        <h1>Witam na stronie!</h1>
        <p>Celem projektu jest utworzenie aplikacji webowej weryfikującej legalność działalności w bazach udostępnianych przez otwarte dane. Dodatkowymi możliwościami w aplikacji był by dostęp do bieżących informacji z zakresu wszczętych postępowań wobec przedsiębiorców.</p>
        <p>Technologie:</p>
        <ul>
          <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
          <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
          <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
          <li><a href='https://semantic-ui.com/'>Semantic UI</a> for layout and styling</li>
        </ul>
        <p>Zakres projektu </p>
        <ul>
          <li>Zebranie baz danych z udostępnianych rejestrów państwowych,</li>
          <li>Przygotowanie api zarządzającymi danymi o przedsiębiorcach</li>
          <li>Przygotowanie responsywnej aplikacji klienckiej,</li>
          <li>Funkcjonalność dodatkowa zbieranie opinii użytkowników o danych przedsiębiorcach</li>
        </ul>
        <div class="ui one column stackable center aligned page grid">
          <div className="column twelve wide">
            <div class="ui huge header">Wpisz NIP przedsiębiorcy którego szukasz</div>
            {/* <NipInput /> */}
            <Input loading={this.state.loading} name="NIP" icon='user' placeholder='NIP' onChange={(e) => { this.handleChange(e) }} value={this.state.nip} />
            <button class="ui button" onClick={() => this.search()}>Szukaj</button>
          </div>
          <div className='column twelve wide'>
          </div>
          {
            this.state.entre.numerEwidencyjny != undefined &&
            <div>Osoba ta występuje w wykazie przedsiębiorców wobec których wszczęto postępowanie w sprawie wykreślenia z rejestru</div>
          }
          <Table celled>
            <Table.Body>
              {
                this.state.entre.numerEwidencyjny != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Numer ewidencyjny sprawy</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.numerEwidencyjny}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.numerWpisuDoRejestru != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Numer wpisu do rejestru</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.numerWpisuDoRejestru}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.firmaLubNazwa != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Firma</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.firmaLubNazwa}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.wojewodztwo != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Województwo</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.wojewodztwo}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.kodPocztowy != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Kod pocztowy</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.kodPocztowy}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.miejscowosc != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Miejscowość</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.miejscowosc}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.ulica != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Ulica</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.ulica}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.formaPrawna != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Nr domu, lokalu</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.nrDomuLokalu}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.formaPrawna != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Forma prawna</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.formaPrawna}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.dataZdarzenia != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Data zdarzenia</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.dataZdarzenia.substring(0,9)}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.dataDoreczenia != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Data doręczenia</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.dataDoreczenia.substring(0,9)}</div>
                  </Table.Cell>
                </Table.Row>
              }
              {
                this.state.entre.statusKsiegi != undefined &&
                <Table.Row>
                  <Table.Cell>
                    <Label>Status księgi</Label>
                  </Table.Cell>
                  <Table.Cell>
                    <div className='ui label' >{this.state.entre.statusKsiegi}</div>
                  </Table.Cell>
                </Table.Row>
              }
            </Table.Body>
          </Table>
        </div>
      </div>
    );
  }
}
