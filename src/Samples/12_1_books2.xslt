<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
            <head>
                <title>Books</title>
                 <link rel="stylesheet" type="text/css" href="books2_xslt.css"/>
            </head>
            <body>
                <xsl:for-each select="books">
                    <table>
                       <tr>
                           <th>Title</th>
                           <th>Author</th>
                           <th>Publisher</th>
                            <th>Price</th>
                            <th>ISBN</th>
	             <th>Content Type</th>
                             <th>Format</th>
                            </tr>
                            <xsl:for-each select="book">
                                <tr>
                                    <td>
                                        <xsl:for-each select="title">
                                                <xsl:apply-templates />
                                        </xsl:for-each>
                                    </td>
                                    <td>
                                        <xsl:for-each select="author">
                                                <xsl:apply-templates />
                                        </xsl:for-each>
                                    </td>
                                    <td>
                                        <xsl:for-each select="publisher">
                                                <xsl:apply-templates />
                                        </xsl:for-each>
                                    </td>
                                    <td>
                                        <xsl:for-each select="price">
                                                <xsl:apply-templates />
                                        </xsl:for-each>
                                    </td>
                                    <td>
                                        <xsl:for-each select="isbn">
                                                <xsl:apply-templates />
                                        </xsl:for-each>
                                    </td>
                                    <td>
                                        <xsl:for-each select="@contentType">
                                                <xsl:value-of select="." />
                                        </xsl:for-each>
                                    </td>
                                    <td>
                                        <xsl:for-each select="@format">
                                                <xsl:value-of select="." />
                                        </xsl:for-each>
                                    </td>
                                </tr>
                            </xsl:for-each>
                    </table>
                </xsl:for-each>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>
