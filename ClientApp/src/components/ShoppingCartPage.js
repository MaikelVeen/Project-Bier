import React, { Component } from 'react';
//import { getOptions } from "../common"  -----> for options dropdown lists

import {
    Header,
    Container,
    Rating,
    Breadcrumb,
    Segment,
    Grid,
    Image,
    Label,
    Button,
    Icon,
    Popup,
    Divider,
    Table,
    Input,
    Card,
    Menu,
    CardGroup,
    List,
    Dropdown,
  } from "semantic-ui-react";

  const Breadcrumb1 = () => (
    <Breadcrumb size='large'>
      <Breadcrumb.Section active>
        <a href='/'>Home</a>
      </Breadcrumb.Section>
      <Breadcrumb.Divider icon='right chevron' />
      <Breadcrumb.Section active>
        <a href='/cart'>Mijn Winkelwagen</a>
      </Breadcrumb.Section>
    </Breadcrumb>
  )
  
  export default Breadcrumb1

  const options = [
    { key: 1, text: '1', value: 1 },
    { key: 2, text: '2', value: 2 },
    { key: 3, text: '3', value: 3 },
    { key: 4, text: '4', value: 4 },
    { key: 5, text: '5', value: 5 },
    { key: 6, text: '6', value: 6 }
  ]

  const DropdownQuantity = () => (
    <Dropdown compact selection options={options} />
  )

  const DeleteButton = () => (
    <div>
      <Button negative>Verwijder</Button>
    </div>
  )

  const ButtonCoC = () => (
    <Button.Group>
      <Button>Annuleren</Button>
      <Button.Or text='of' />
      <Button positive>Doorgaan</Button>
    </Button.Group>
  )

  const Space = () => (
    " "
  )

  const ButtonCheck = () => <Button>Check</Button>

  const Input1 = () => <Input placeholder='Vul je kortingscode in...' />

  const ListProducts = () => (
    <List celled>
      <List.Item>
        <Image src='https://react.semantic-ui.com/images/wireframe/image.png' size="small" />
        <List.Content>
          <List.Header>Vandestreek Bock jij of bock ik?</List.Header>
          <Divider hidden/>
          Hoeveelheid:
          <Space />
          <DropdownQuantity />
          <Divider hidden/>
          Prijs: €2,19
          <DeleteButton />
        </List.Content>
      </List.Item>
      <List.Item>
        <Image src='https://react.semantic-ui.com/images/wireframe/image.png' size="small" />
        <List.Content>
          <List.Header>Brussels Beer Project Delta IPA</List.Header>
          <Divider hidden/>
          Hoeveelheid: 
          <Space />
          <DropdownQuantity />
          <Divider hidden/>
          Prijs: €2.95
          <DeleteButton />
        </List.Content>
      </List.Item>
      <List.Item>
        <Image src='https://react.semantic-ui.com/images/wireframe/image.png' size="small" />
        <List.Content>
          <List.Header>Paulaner Oktoberfest</List.Header>
          <Divider hidden/>
          Hoeveelheid: 
          <Space />
          <DropdownQuantity />
          <Divider hidden/>
          Prijs: €2.59
          <DeleteButton />
        </List.Content>
      </List.Item>
    </List>
  )
  
export class ShoppingCart extends Component {
    render() {
          return (
              <Container>
                  <Divider hidden />
                  <Breadcrumb1 />
                  <Divider />
                  <h1>Mijn Winkelwagen</h1>
                  <Divider hidden />
                  <ListProducts />
                  <Container textAlign='left'>
                    <h4>Kortingscode: <Input1 /><ButtonCheck /></h4>
                  </Container>
                  <Container textAlign='right'>
                  <h3>Totaal: </h3>
                  <ButtonCoC />
                  </Container>
              </Container>
          )
      }

};
